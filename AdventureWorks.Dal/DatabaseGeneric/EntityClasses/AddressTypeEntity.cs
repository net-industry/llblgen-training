﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using AdventureWorks.Dal;
using AdventureWorks.Dal.HelperClasses;
using AdventureWorks.Dal.FactoryClasses;
using AdventureWorks.Dal.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'AddressType'.<br/><br/></summary>
	[Serializable]
	public partial class AddressTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<BusinessEntityAddressEntity> _businessEntityAddresses;
		private EntityCollection<AddressEntity> _addressCollectionViaBusinessEntityAddress;
		private EntityCollection<BusinessEntityEntity> _businessEntityCollectionViaBusinessEntityAddress;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BusinessEntityAddresses</summary>
			public static readonly string BusinessEntityAddresses = "BusinessEntityAddresses";
			/// <summary>Member name AddressCollectionViaBusinessEntityAddress</summary>
			public static readonly string AddressCollectionViaBusinessEntityAddress = "AddressCollectionViaBusinessEntityAddress";
			/// <summary>Member name BusinessEntityCollectionViaBusinessEntityAddress</summary>
			public static readonly string BusinessEntityCollectionViaBusinessEntityAddress = "BusinessEntityCollectionViaBusinessEntityAddress";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AddressTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public AddressTypeEntity():base("AddressTypeEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AddressTypeEntity(IEntityFields2 fields):base("AddressTypeEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AddressTypeEntity</param>
		public AddressTypeEntity(IValidator validator):base("AddressTypeEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="addressTypeId">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AddressTypeEntity(System.Int32 addressTypeId):base("AddressTypeEntity")
		{
			InitClassEmpty(null, null);
			this.AddressTypeId = addressTypeId;
		}

		/// <summary> CTor</summary>
		/// <param name="addressTypeId">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="validator">The custom validator object for this AddressTypeEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AddressTypeEntity(System.Int32 addressTypeId, IValidator validator):base("AddressTypeEntity")
		{
			InitClassEmpty(validator, null);
			this.AddressTypeId = addressTypeId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AddressTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_businessEntityAddresses = (EntityCollection<BusinessEntityAddressEntity>)info.GetValue("_businessEntityAddresses", typeof(EntityCollection<BusinessEntityAddressEntity>));
				_addressCollectionViaBusinessEntityAddress = (EntityCollection<AddressEntity>)info.GetValue("_addressCollectionViaBusinessEntityAddress", typeof(EntityCollection<AddressEntity>));
				_businessEntityCollectionViaBusinessEntityAddress = (EntityCollection<BusinessEntityEntity>)info.GetValue("_businessEntityCollectionViaBusinessEntityAddress", typeof(EntityCollection<BusinessEntityEntity>));
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}


		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "BusinessEntityAddresses":
					this.BusinessEntityAddresses.Add((BusinessEntityAddressEntity)entity);
					break;
				case "AddressCollectionViaBusinessEntityAddress":
					this.AddressCollectionViaBusinessEntityAddress.IsReadOnly = false;
					this.AddressCollectionViaBusinessEntityAddress.Add((AddressEntity)entity);
					this.AddressCollectionViaBusinessEntityAddress.IsReadOnly = true;
					break;
				case "BusinessEntityCollectionViaBusinessEntityAddress":
					this.BusinessEntityCollectionViaBusinessEntityAddress.IsReadOnly = false;
					this.BusinessEntityCollectionViaBusinessEntityAddress.Add((BusinessEntityEntity)entity);
					this.BusinessEntityCollectionViaBusinessEntityAddress.IsReadOnly = true;
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "BusinessEntityAddresses":
					toReturn.Add(Relations.BusinessEntityAddressEntityUsingAddressTypeId);
					break;
				case "AddressCollectionViaBusinessEntityAddress":
					toReturn.Add(Relations.BusinessEntityAddressEntityUsingAddressTypeId, "AddressTypeEntity__", "BusinessEntityAddress_", JoinHint.None);
					toReturn.Add(BusinessEntityAddressEntity.Relations.AddressEntityUsingAddressId, "BusinessEntityAddress_", string.Empty, JoinHint.None);
					break;
				case "BusinessEntityCollectionViaBusinessEntityAddress":
					toReturn.Add(Relations.BusinessEntityAddressEntityUsingAddressTypeId, "AddressTypeEntity__", "BusinessEntityAddress_", JoinHint.None);
					toReturn.Add(BusinessEntityAddressEntity.Relations.BusinessEntityEntityUsingBusinessEntityId, "BusinessEntityAddress_", string.Empty, JoinHint.None);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "BusinessEntityAddresses":
					this.BusinessEntityAddresses.Add((BusinessEntityAddressEntity)relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "BusinessEntityAddresses":
					this.PerformRelatedEntityRemoval(this.BusinessEntityAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.BusinessEntityAddresses);
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_businessEntityAddresses", ((_businessEntityAddresses!=null) && (_businessEntityAddresses.Count>0) && !this.MarkedForDeletion)?_businessEntityAddresses:null);
				info.AddValue("_addressCollectionViaBusinessEntityAddress", ((_addressCollectionViaBusinessEntityAddress!=null) && (_addressCollectionViaBusinessEntityAddress.Count>0) && !this.MarkedForDeletion)?_addressCollectionViaBusinessEntityAddress:null);
				info.AddValue("_businessEntityCollectionViaBusinessEntityAddress", ((_businessEntityCollectionViaBusinessEntityAddress!=null) && (_businessEntityCollectionViaBusinessEntityAddress.Count>0) && !this.MarkedForDeletion)?_businessEntityCollectionViaBusinessEntityAddress:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AddressTypeRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BusinessEntityAddress' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntityAddresses()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BusinessEntityAddressFields.AddressTypeId, null, ComparisonOperator.Equal, this.AddressTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressCollectionViaBusinessEntityAddress()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AddressCollectionViaBusinessEntityAddress"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressTypeFields.AddressTypeId, null, ComparisonOperator.Equal, this.AddressTypeId, "AddressTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BusinessEntity' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntityCollectionViaBusinessEntityAddress()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("BusinessEntityCollectionViaBusinessEntityAddress"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressTypeFields.AddressTypeId, null, ComparisonOperator.Equal, this.AddressTypeId, "AddressTypeEntity__"));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(AddressTypeEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._businessEntityAddresses);
			collectionsQueue.Enqueue(this._addressCollectionViaBusinessEntityAddress);
			collectionsQueue.Enqueue(this._businessEntityCollectionViaBusinessEntityAddress);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._businessEntityAddresses = (EntityCollection<BusinessEntityAddressEntity>) collectionsQueue.Dequeue();
			this._addressCollectionViaBusinessEntityAddress = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._businessEntityCollectionViaBusinessEntityAddress = (EntityCollection<BusinessEntityEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._businessEntityAddresses != null);
			toReturn |= (this._addressCollectionViaBusinessEntityAddress != null);
			toReturn |= (this._businessEntityCollectionViaBusinessEntityAddress != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BusinessEntityAddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityAddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BusinessEntityEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("BusinessEntityAddresses", _businessEntityAddresses);
			toReturn.Add("AddressCollectionViaBusinessEntityAddress", _addressCollectionViaBusinessEntityAddress);
			toReturn.Add("BusinessEntityCollectionViaBusinessEntityAddress", _businessEntityCollectionViaBusinessEntityAddress);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AddressTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this AddressTypeEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AddressTypeRelations Relations
		{
			get	{ return new AddressTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntityAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntityAddresses
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BusinessEntityAddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityAddressEntityFactory))), (IEntityRelation)GetRelationsForField("BusinessEntityAddresses")[0], (int)AdventureWorks.Dal.EntityType.AddressTypeEntity, (int)AdventureWorks.Dal.EntityType.BusinessEntityAddressEntity, 0, null, null, null, null, "BusinessEntityAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressCollectionViaBusinessEntityAddress
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.BusinessEntityAddressEntityUsingAddressTypeId;
				intermediateRelation.SetAliases(string.Empty, "BusinessEntityAddress_");
				return new PrefetchPathElement2(new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressTypeEntity, (int)AdventureWorks.Dal.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaBusinessEntityAddress"), null, "AddressCollectionViaBusinessEntityAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntityCollectionViaBusinessEntityAddress
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.BusinessEntityAddressEntityUsingAddressTypeId;
				intermediateRelation.SetAliases(string.Empty, "BusinessEntityAddress_");
				return new PrefetchPathElement2(new EntityCollection<BusinessEntityEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.AddressTypeEntity, (int)AdventureWorks.Dal.EntityType.BusinessEntityEntity, 0, null, null, GetRelationsForField("BusinessEntityCollectionViaBusinessEntityAddress"), null, "BusinessEntityCollectionViaBusinessEntityAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The AddressTypeId property of the Entity AddressType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."AddressTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AddressTypeId
		{
			get { return (System.Int32)GetValue((int)AddressTypeFieldIndex.AddressTypeId, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.AddressTypeId, value); }
		}

		/// <summary> The ModifiedDate property of the Entity AddressType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)AddressTypeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity AddressType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AddressTypeFieldIndex.Name, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.Name, value); }
		}

		/// <summary> The Rowguid property of the Entity AddressType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)AddressTypeFieldIndex.Rowguid, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.Rowguid, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BusinessEntityAddressEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BusinessEntityAddressEntity))]
		public virtual EntityCollection<BusinessEntityAddressEntity> BusinessEntityAddresses
		{
			get { return GetOrCreateEntityCollection<BusinessEntityAddressEntity, BusinessEntityAddressEntityFactory>("AddressType", true, false, ref _businessEntityAddresses);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> AddressCollectionViaBusinessEntityAddress
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("AddressTypeCollectionViaBusinessEntityAddress", false, true, ref _addressCollectionViaBusinessEntityAddress);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BusinessEntityEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BusinessEntityEntity))]
		public virtual EntityCollection<BusinessEntityEntity> BusinessEntityCollectionViaBusinessEntityAddress
		{
			get { return GetOrCreateEntityCollection<BusinessEntityEntity, BusinessEntityEntityFactory>("AddressTypeCollectionViaBusinessEntityAddress", false, true, ref _businessEntityCollectionViaBusinessEntityAddress);	}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the AdventureWorks.Dal.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.EntityType.AddressTypeEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
