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
	
	/// <summary>Entity class which represents the entity 'PhoneNumberType'.<br/><br/></summary>
	[Serializable]
	public partial class PhoneNumberTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<PersonPhoneEntity> _personPhones;
		private EntityCollection<PersonEntity> _personCollectionViaPersonPhone;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name PersonPhones</summary>
			public static readonly string PersonPhones = "PersonPhones";
			/// <summary>Member name PersonCollectionViaPersonPhone</summary>
			public static readonly string PersonCollectionViaPersonPhone = "PersonCollectionViaPersonPhone";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PhoneNumberTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public PhoneNumberTypeEntity():base("PhoneNumberTypeEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PhoneNumberTypeEntity(IEntityFields2 fields):base("PhoneNumberTypeEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PhoneNumberTypeEntity</param>
		public PhoneNumberTypeEntity(IValidator validator):base("PhoneNumberTypeEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="phoneNumberTypeId">PK value for PhoneNumberType which data should be fetched into this PhoneNumberType object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PhoneNumberTypeEntity(System.Int32 phoneNumberTypeId):base("PhoneNumberTypeEntity")
		{
			InitClassEmpty(null, null);
			this.PhoneNumberTypeId = phoneNumberTypeId;
		}

		/// <summary> CTor</summary>
		/// <param name="phoneNumberTypeId">PK value for PhoneNumberType which data should be fetched into this PhoneNumberType object</param>
		/// <param name="validator">The custom validator object for this PhoneNumberTypeEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PhoneNumberTypeEntity(System.Int32 phoneNumberTypeId, IValidator validator):base("PhoneNumberTypeEntity")
		{
			InitClassEmpty(validator, null);
			this.PhoneNumberTypeId = phoneNumberTypeId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected PhoneNumberTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_personPhones = (EntityCollection<PersonPhoneEntity>)info.GetValue("_personPhones", typeof(EntityCollection<PersonPhoneEntity>));
				_personCollectionViaPersonPhone = (EntityCollection<PersonEntity>)info.GetValue("_personCollectionViaPersonPhone", typeof(EntityCollection<PersonEntity>));
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
				case "PersonPhones":
					this.PersonPhones.Add((PersonPhoneEntity)entity);
					break;
				case "PersonCollectionViaPersonPhone":
					this.PersonCollectionViaPersonPhone.IsReadOnly = false;
					this.PersonCollectionViaPersonPhone.Add((PersonEntity)entity);
					this.PersonCollectionViaPersonPhone.IsReadOnly = true;
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
				case "PersonPhones":
					toReturn.Add(Relations.PersonPhoneEntityUsingPhoneNumberTypeId);
					break;
				case "PersonCollectionViaPersonPhone":
					toReturn.Add(Relations.PersonPhoneEntityUsingPhoneNumberTypeId, "PhoneNumberTypeEntity__", "PersonPhone_", JoinHint.None);
					toReturn.Add(PersonPhoneEntity.Relations.PersonEntityUsingBusinessEntityId, "PersonPhone_", string.Empty, JoinHint.None);
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
				case "PersonPhones":
					this.PersonPhones.Add((PersonPhoneEntity)relatedEntity);
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
				case "PersonPhones":
					this.PerformRelatedEntityRemoval(this.PersonPhones, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.PersonPhones);
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
				info.AddValue("_personPhones", ((_personPhones!=null) && (_personPhones.Count>0) && !this.MarkedForDeletion)?_personPhones:null);
				info.AddValue("_personCollectionViaPersonPhone", ((_personCollectionViaPersonPhone!=null) && (_personCollectionViaPersonPhone.Count>0) && !this.MarkedForDeletion)?_personCollectionViaPersonPhone:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new PhoneNumberTypeRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PersonPhone' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPersonPhones()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PersonPhoneFields.PhoneNumberTypeId, null, ComparisonOperator.Equal, this.PhoneNumberTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPersonCollectionViaPersonPhone()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("PersonCollectionViaPersonPhone"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PhoneNumberTypeFields.PhoneNumberTypeId, null, ComparisonOperator.Equal, this.PhoneNumberTypeId, "PhoneNumberTypeEntity__"));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(PhoneNumberTypeEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._personPhones);
			collectionsQueue.Enqueue(this._personCollectionViaPersonPhone);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._personPhones = (EntityCollection<PersonPhoneEntity>) collectionsQueue.Dequeue();
			this._personCollectionViaPersonPhone = (EntityCollection<PersonEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._personPhones != null);
			toReturn |= (this._personCollectionViaPersonPhone != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PersonPhoneEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PersonPhoneEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PersonEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("PersonPhones", _personPhones);
			toReturn.Add("PersonCollectionViaPersonPhone", _personCollectionViaPersonPhone);
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
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PhoneNumberTypeId", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PhoneNumberTypeEntity</param>
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
		public  static PhoneNumberTypeRelations Relations
		{
			get	{ return new PhoneNumberTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PersonPhone' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPersonPhones
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PersonPhoneEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PersonPhoneEntityFactory))), (IEntityRelation)GetRelationsForField("PersonPhones")[0], (int)AdventureWorks.Dal.EntityType.PhoneNumberTypeEntity, (int)AdventureWorks.Dal.EntityType.PersonPhoneEntity, 0, null, null, null, null, "PersonPhones", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPersonCollectionViaPersonPhone
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.PersonPhoneEntityUsingPhoneNumberTypeId;
				intermediateRelation.SetAliases(string.Empty, "PersonPhone_");
				return new PrefetchPathElement2(new EntityCollection<PersonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PersonEntityFactory))), intermediateRelation,
					(int)AdventureWorks.Dal.EntityType.PhoneNumberTypeEntity, (int)AdventureWorks.Dal.EntityType.PersonEntity, 0, null, null, GetRelationsForField("PersonCollectionViaPersonPhone"), null, "PersonCollectionViaPersonPhone", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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

		/// <summary> The ModifiedDate property of the Entity PhoneNumberType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PhoneNumberType"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PhoneNumberTypeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)PhoneNumberTypeFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity PhoneNumberType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PhoneNumberType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)PhoneNumberTypeFieldIndex.Name, true); }
			set	{ SetValue((int)PhoneNumberTypeFieldIndex.Name, value); }
		}

		/// <summary> The PhoneNumberTypeId property of the Entity PhoneNumberType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PhoneNumberType"."PhoneNumberTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 PhoneNumberTypeId
		{
			get { return (System.Int32)GetValue((int)PhoneNumberTypeFieldIndex.PhoneNumberTypeId, true); }
			set	{ SetValue((int)PhoneNumberTypeFieldIndex.PhoneNumberTypeId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PersonPhoneEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PersonPhoneEntity))]
		public virtual EntityCollection<PersonPhoneEntity> PersonPhones
		{
			get { return GetOrCreateEntityCollection<PersonPhoneEntity, PersonPhoneEntityFactory>("PhoneNumberType", true, false, ref _personPhones);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PersonEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PersonEntity))]
		public virtual EntityCollection<PersonEntity> PersonCollectionViaPersonPhone
		{
			get { return GetOrCreateEntityCollection<PersonEntity, PersonEntityFactory>("PhoneNumberTypeCollectionViaPersonPhone", false, true, ref _personCollectionViaPersonPhone);	}
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
			get { return (int)AdventureWorks.Dal.EntityType.PhoneNumberTypeEntity; }
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