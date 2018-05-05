///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Let3arafo.Data;
using Let3arafo.Data.HelperClasses;
using Let3arafo.Data.FactoryClasses;
using Let3arafo.Data.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Let3arafo.Data.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'CommunityUser'.<br/><br/></summary>
	[Serializable]
	public partial class CommunityUserEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private CommunityEntity _community;
		private UserEntity _user;
		private UserEntity _user1;
		private UserEntity _user2;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Community</summary>
			public static readonly string Community = "Community";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
			/// <summary>Member name User1</summary>
			public static readonly string User1 = "User1";
			/// <summary>Member name User2</summary>
			public static readonly string User2 = "User2";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CommunityUserEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public CommunityUserEntity():base("CommunityUserEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CommunityUserEntity(IEntityFields2 fields):base("CommunityUserEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CommunityUserEntity</param>
		public CommunityUserEntity(IValidator validator):base("CommunityUserEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for CommunityUser which data should be fetched into this CommunityUser object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CommunityUserEntity(System.Int32 id):base("CommunityUserEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for CommunityUser which data should be fetched into this CommunityUser object</param>
		/// <param name="validator">The custom validator object for this CommunityUserEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CommunityUserEntity(System.Int32 id, IValidator validator):base("CommunityUserEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CommunityUserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_community = (CommunityEntity)info.GetValue("_community", typeof(CommunityEntity));
				if(_community!=null)
				{
					_community.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_user = (UserEntity)info.GetValue("_user", typeof(UserEntity));
				if(_user!=null)
				{
					_user.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_user1 = (UserEntity)info.GetValue("_user1", typeof(UserEntity));
				if(_user1!=null)
				{
					_user1.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_user2 = (UserEntity)info.GetValue("_user2", typeof(UserEntity));
				if(_user2!=null)
				{
					_user2.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CommunityUserFieldIndex)fieldIndex)
			{
				case CommunityUserFieldIndex.CommunityId:
					DesetupSyncCommunity(true, false);
					break;
				case CommunityUserFieldIndex.CreatedByUserId:
					DesetupSyncUser(true, false);
					break;
				case CommunityUserFieldIndex.LastModifiedByUserId:
					DesetupSyncUser1(true, false);
					break;
				case CommunityUserFieldIndex.UserId:
					DesetupSyncUser2(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Community":
					this.Community = (CommunityEntity)entity;
					break;
				case "User":
					this.User = (UserEntity)entity;
					break;
				case "User1":
					this.User1 = (UserEntity)entity;
					break;
				case "User2":
					this.User2 = (UserEntity)entity;
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
				case "Community":
					toReturn.Add(Relations.CommunityEntityUsingCommunityId);
					break;
				case "User":
					toReturn.Add(Relations.UserEntityUsingCreatedByUserId);
					break;
				case "User1":
					toReturn.Add(Relations.UserEntityUsingLastModifiedByUserId);
					break;
				case "User2":
					toReturn.Add(Relations.UserEntityUsingUserId);
					break;
				default:
					break;				
			}
			return toReturn;
		}

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

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Community":
					SetupSyncCommunity(relatedEntity);
					break;
				case "User":
					SetupSyncUser(relatedEntity);
					break;
				case "User1":
					SetupSyncUser1(relatedEntity);
					break;
				case "User2":
					SetupSyncUser2(relatedEntity);
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
				case "Community":
					DesetupSyncCommunity(false, true);
					break;
				case "User":
					DesetupSyncUser(false, true);
					break;
				case "User1":
					DesetupSyncUser1(false, true);
					break;
				case "User2":
					DesetupSyncUser2(false, true);
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
			if(_community!=null)
			{
				toReturn.Add(_community);
			}
			if(_user!=null)
			{
				toReturn.Add(_user);
			}
			if(_user1!=null)
			{
				toReturn.Add(_user1);
			}
			if(_user2!=null)
			{
				toReturn.Add(_user2);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
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
				info.AddValue("_community", (!this.MarkedForDeletion?_community:null));
				info.AddValue("_user", (!this.MarkedForDeletion?_user:null));
				info.AddValue("_user1", (!this.MarkedForDeletion?_user1:null));
				info.AddValue("_user2", (!this.MarkedForDeletion?_user2:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CommunityUserRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Community' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCommunity()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CommunityFields.Id, null, ComparisonOperator.Equal, this.CommunityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'User' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.Id, null, ComparisonOperator.Equal, this.CreatedByUserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'User' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.Id, null, ComparisonOperator.Equal, this.LastModifiedByUserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'User' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser2()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.Id, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(CommunityUserEntityFactory));
		}

		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Community", _community);
			toReturn.Add("User", _user);
			toReturn.Add("User1", _user1);
			toReturn.Add("User2", _user2);
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
			_fieldsCustomProperties.Add("CommunityId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CreatedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastModifiedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _community</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCommunity(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _community, new PropertyChangedEventHandler( OnCommunityPropertyChanged ), "Community", Let3arafo.Data.RelationClasses.StaticCommunityUserRelations.CommunityEntityUsingCommunityIdStatic, true, signalRelatedEntity, "CommunityUsers", resetFKFields, new int[] { (int)CommunityUserFieldIndex.CommunityId } );
			_community = null;
		}

		/// <summary> setups the sync logic for member _community</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCommunity(IEntityCore relatedEntity)
		{
			if(_community!=relatedEntity)
			{
				DesetupSyncCommunity(true, true);
				_community = (CommunityEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _community, new PropertyChangedEventHandler( OnCommunityPropertyChanged ), "Community", Let3arafo.Data.RelationClasses.StaticCommunityUserRelations.CommunityEntityUsingCommunityIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCommunityPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _user</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", Let3arafo.Data.RelationClasses.StaticCommunityUserRelations.UserEntityUsingCreatedByUserIdStatic, true, signalRelatedEntity, "CommunityUsers", resetFKFields, new int[] { (int)CommunityUserFieldIndex.CreatedByUserId } );
			_user = null;
		}

		/// <summary> setups the sync logic for member _user</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUser(IEntityCore relatedEntity)
		{
			if(_user!=relatedEntity)
			{
				DesetupSyncUser(true, true);
				_user = (UserEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", Let3arafo.Data.RelationClasses.StaticCommunityUserRelations.UserEntityUsingCreatedByUserIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _user1</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser1(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _user1, new PropertyChangedEventHandler( OnUser1PropertyChanged ), "User1", Let3arafo.Data.RelationClasses.StaticCommunityUserRelations.UserEntityUsingLastModifiedByUserIdStatic, true, signalRelatedEntity, "CommunityUsers1", resetFKFields, new int[] { (int)CommunityUserFieldIndex.LastModifiedByUserId } );
			_user1 = null;
		}

		/// <summary> setups the sync logic for member _user1</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUser1(IEntityCore relatedEntity)
		{
			if(_user1!=relatedEntity)
			{
				DesetupSyncUser1(true, true);
				_user1 = (UserEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _user1, new PropertyChangedEventHandler( OnUser1PropertyChanged ), "User1", Let3arafo.Data.RelationClasses.StaticCommunityUserRelations.UserEntityUsingLastModifiedByUserIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUser1PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _user2</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser2(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _user2, new PropertyChangedEventHandler( OnUser2PropertyChanged ), "User2", Let3arafo.Data.RelationClasses.StaticCommunityUserRelations.UserEntityUsingUserIdStatic, true, signalRelatedEntity, "CommunityUsers2", resetFKFields, new int[] { (int)CommunityUserFieldIndex.UserId } );
			_user2 = null;
		}

		/// <summary> setups the sync logic for member _user2</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUser2(IEntityCore relatedEntity)
		{
			if(_user2!=relatedEntity)
			{
				DesetupSyncUser2(true, true);
				_user2 = (UserEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _user2, new PropertyChangedEventHandler( OnUser2PropertyChanged ), "User2", Let3arafo.Data.RelationClasses.StaticCommunityUserRelations.UserEntityUsingUserIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUser2PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CommunityUserEntity</param>
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
		public  static CommunityUserRelations Relations
		{
			get	{ return new CommunityUserRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Community' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCommunity
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CommunityEntityFactory))),	(IEntityRelation)GetRelationsForField("Community")[0], (int)Let3arafo.Data.EntityType.CommunityUserEntity, (int)Let3arafo.Data.EntityType.CommunityEntity, 0, null, null, null, null, "Community", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))),	(IEntityRelation)GetRelationsForField("User")[0], (int)Let3arafo.Data.EntityType.CommunityUserEntity, (int)Let3arafo.Data.EntityType.UserEntity, 0, null, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser1
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))),	(IEntityRelation)GetRelationsForField("User1")[0], (int)Let3arafo.Data.EntityType.CommunityUserEntity, (int)Let3arafo.Data.EntityType.UserEntity, 0, null, null, null, null, "User1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser2
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))),	(IEntityRelation)GetRelationsForField("User2")[0], (int)Let3arafo.Data.EntityType.CommunityUserEntity, (int)Let3arafo.Data.EntityType.UserEntity, 0, null, null, null, null, "User2", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CommunityId property of the Entity CommunityUser<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CommunityUser"."CommunityId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CommunityId
		{
			get { return (System.Int32)GetValue((int)CommunityUserFieldIndex.CommunityId, true); }
			set	{ SetValue((int)CommunityUserFieldIndex.CommunityId, value); }
		}

		/// <summary> The CreatedByUserId property of the Entity CommunityUser<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CommunityUser"."CreatedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CreatedByUserId
		{
			get { return (System.Int32)GetValue((int)CommunityUserFieldIndex.CreatedByUserId, true); }
			set	{ SetValue((int)CommunityUserFieldIndex.CreatedByUserId, value); }
		}

		/// <summary> The DateCreated property of the Entity CommunityUser<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CommunityUser"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)CommunityUserFieldIndex.DateCreated, true); }
			set	{ SetValue((int)CommunityUserFieldIndex.DateCreated, value); }
		}

		/// <summary> The Id property of the Entity CommunityUser<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CommunityUser"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)CommunityUserFieldIndex.Id, true); }
			set	{ SetValue((int)CommunityUserFieldIndex.Id, value); }
		}

		/// <summary> The LastModified property of the Entity CommunityUser<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CommunityUser"."LastModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime LastModified
		{
			get { return (System.DateTime)GetValue((int)CommunityUserFieldIndex.LastModified, true); }
			set	{ SetValue((int)CommunityUserFieldIndex.LastModified, value); }
		}

		/// <summary> The LastModifiedByUserId property of the Entity CommunityUser<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CommunityUser"."LastModifiedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> LastModifiedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)CommunityUserFieldIndex.LastModifiedByUserId, false); }
			set	{ SetValue((int)CommunityUserFieldIndex.LastModifiedByUserId, value); }
		}

		/// <summary> The UserId property of the Entity CommunityUser<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CommunityUser"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 UserId
		{
			get { return (System.Int32)GetValue((int)CommunityUserFieldIndex.UserId, true); }
			set	{ SetValue((int)CommunityUserFieldIndex.UserId, value); }
		}

		/// <summary> Gets / sets related entity of type 'CommunityEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CommunityEntity Community
		{
			get	{ return _community; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCommunity(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CommunityUsers", "Community", _community, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UserEntity User
		{
			get	{ return _user; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUser(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CommunityUsers", "User", _user, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UserEntity User1
		{
			get	{ return _user1; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUser1(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CommunityUsers1", "User1", _user1, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UserEntity User2
		{
			get	{ return _user2; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUser2(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CommunityUsers2", "User2", _user2, true); 
				}
			}
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
		
		/// <summary>Returns the Let3arafo.Data.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)Let3arafo.Data.EntityType.CommunityUserEntity; }
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
