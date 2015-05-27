using System;
using System.Runtime.InteropServices;

namespace NetIndustry.Library.LLBLGen
{
	/// <summary>
	/// Represents a sequential guid generator.
	/// </summary>
	/// <remarks>
	/// Sequential guids can improve database performance. See http://www.informit.com/articles/article.aspx?p=25862 
	/// for more information.
	/// 
	/// Note: guids generated on different machines will not be sequential since the MAC address of
	/// the network card is used to make the result unique.
	/// </remarks>
	public static class SequentialGuid
	{
		[DllImport("rpcrt4.dll", SetLastError = true)]
		static extern int UuidCreateSequential(out Guid guid);

		/// <summary>
		/// Returns the next sequential guid.
		/// </summary>
		/// <returns>The next sequential guid.</returns>
		public static Guid Next()
		{
			Guid guid;

			int status = UuidCreateSequential(out guid);
			if (status != 0) // 0 = RPC_S_OK
				throw new InvalidOperationException("UuidCreateSequential failed: " + status);

			var source = guid.ToByteArray();
			var destination = guid.ToByteArray();

			// SQL Server reorders the guids created by UuidCreateSequential to make them work better with the database engine.
			// See: http://blogs.msdn.com/sqlprogrammability/archive/2006/03/23/559061.aspx and http://jorriss.net/cs/blogs/jorrissnet/archive/2008/04/24/unraveling-the-mysteries-of-newsequentialid.aspx 
			//      for more information.

			// re-order bytes of the integer. ( remove the little endian format )
			destination[0] = source[3];
			destination[1] = source[2];
			destination[2] = source[1];
			destination[3] = source[0];

			// re-order bytes of the first short. ( remove the little endian format )
			destination[4] = source[5];
			destination[5] = source[4];

			// re-order bytes of the second short. ( remove the little endian format )
			destination[6] = source[7];
			destination[7] = source[6];

			// note:bytes[] 8-15 are not manipulated by SQL Server.

			return new Guid(destination);
		}
	}
}