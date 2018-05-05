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
	/// <summary>Entity class which represents the entity 'User'.<br/><br/></summary>
	[Serializable]
	public partial class UserEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<CommunityEntity> _communities;
		private EntityCollection<CommunityEntity> _communities1;
		private EntityCollection<CommunityEntity> _communities2;
		private EntityCollection<CommunityUserEntity> _communityUsers;
		private EntityCollection<CommunityUserEntity> _communityUsers1;
		private EntityCollection<CommunityUserEntity> _communityUsers2;
		private EntityCollection<PostEntity> _posts;
		private EntityCollection<PostEntity> _posts1;
		private CompanyEntity _company;
		private PersonEntity _person;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Company</summary>
			public static readonly string Company = "Company";
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
			/// <summary>Member name Communities</summary>
			public static readonly string Communities = "Communities";
			/// <summary>Member name Communities1</summary>
			public static readonly string Communities1 = "Communities1";
			/// <summary>Member name Communities2</summary>
			public static readonly string Communities2 = "Communities2";
			/// <summary>Member name CommunityUsers</summary>
			public static readonly string CommunityUsers = "CommunityUsers";
			/// <summary>Member name CommunityUsers1</summary>
			public static readonly string CommunityUsers1 = "CommunityUsers1";
			/// <summary>Member name CommunityUsers2</summary>
			public static readonly string CommunityUsers2 = "CommunityUsers2";
			/// <summary>Member name Posts</summary>
			public static readonly string Posts = "Posts";
			/// <summary>Member name Posts1</summary>
			public static readonly string Posts1 = "Posts1";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UserEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public UserEntity():base("UserEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UserEntity(IEntityFields2 fields):base("UserEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(IValidator validator):base("UserEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public UserEntity(System.Int32 id):base("UserEntity")
		{
			InitClassEmpty(null, null);
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public UserEntity(System.Int32 id, IValidator validator):base("UserEntity")
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected UserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_communities = (EntityCollection<CommunityEntity>)info.GetValue("_communities", typeof(EntityCollection<CommunityEntity>));
				_communities1 = (EntityCollection<CommunityEntity>)info.GetValue("_communities1", typeof(EntityCollection<CommunityEntity>));
				_communities2 = (EntityCollection<CommunityEntity>)info.GetValue("_communities2", typeof(EntityCollection<CommunityEntity>));
				_communityUsers = (EntityCollection<CommunityUserEntity>)info.GetValue("_communityUsers", typeof(EntityCollection<CommunityUserEntity>));
				_communityUsers1 = (EntityCollection<CommunityUserEntity>)info.GetValue("_communityUsers1", typeof(EntityCollection<CommunityUserEntity>));
				_communityUsers2 = (EntityCollection<CommunityUserEntity>)info.GetValue("_communityUsers2", typeof(EntityCollection<CommunityUserEntity>));
				_posts = (EntityCollection<PostEntity>)info.GetValue("_posts", typeof(EntityCollection<PostEntity>));
				_posts1 = (EntityCollection<PostEntity>)info.GetValue("_posts1", typeof(EntityCollection<PostEntity>));
				_company = (CompanyEntity)info.GetValue("_company", typeof(CompanyEntity));
				if(_company!=null)
				{
					_company.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_person = (PersonEntity)info.GetValue("_person", typeof(PersonEntity));
				if(_person!=null)
				{
					_person.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((UserFieldIndex)fieldIndex)
			{
				case UserFieldIndex.CompanyId:
					DesetupSyncCompany(true, false);
					break;
				case UserFieldIndex.PersonId:
					DesetupSyncPerson(true, false);
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
				case "Company":
					this.Company = (CompanyEntity)entity;
					break;
				case "Person":
					this.Person = (PersonEntity)entity;
					break;
				case "Communities":
					this.Communities.Add((CommunityEntity)entity);
					break;
				case "Communities1":
					this.Communities1.Add((CommunityEntity)entity);
					break;
				case "Communities2":
					this.Communities2.Add((CommunityEntity)entity);
					break;
				case "CommunityUsers":
					this.CommunityUsers.Add((CommunityUserEntity)entity);
					break;
				case "CommunityUsers1":
					this.CommunityUsers1.Add((CommunityUserEntity)entity);
					break;
				case "CommunityUsers2":
					this.CommunityUsers2.Add((CommunityUserEntity)entity);
					break;
				case "Posts":
					this.Posts.Add((PostEntity)entity);
					break;
				case "Posts1":
					this.Posts1.Add((PostEntity)entity);
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
				case "Company":
					toReturn.Add(Relations.CompanyEntityUsingCompanyId);
					break;
				case "Person":
					toReturn.Add(Relations.PersonEntityUsingPersonId);
					break;
				case "Communities":
					toReturn.Add(Relations.CommunityEntityUsingCreatedByUserId);
					break;
				case "Communities1":
					toReturn.Add(Relations.CommunityEntityUsingLastModifiedByUserId);
					break;
				case "Communities2":
					toReturn.Add(Relations.CommunityEntityUsingManagerId);
					break;
				case "CommunityUsers":
					toReturn.Add(Relations.CommunityUserEntityUsingCreatedByUserId);
					break;
				case "CommunityUsers1":
					toReturn.Add(Relations.CommunityUserEntityUsingLastModifiedByUserId);
					break;
				case "CommunityUsers2":
					toReturn.Add(Relations.CommunityUserEntityUsingUserId);
					break;
				case "Posts":
					toReturn.Add(Relations.PostEntityUsingCreatedByUserId);
					break;
				case "Posts1":
					toReturn.Add(Relations.PostEntityUsingLastModifiedByUserId);
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
				case "Company":
					SetupSyncCompany(relatedEntity);
					break;
				case "Person":
					SetupSyncPerson(relatedEntity);
					break;
				case "Communities":
					this.Communities.Add((CommunityEntity)relatedEntity);
					break;
				case "Communities1":
					this.Communities1.Add((CommunityEntity)relatedEntity);
					break;
				case "Communities2":
					this.Communities2.Add((CommunityEntity)relatedEntity);
					break;
				case "CommunityUsers":
					this.CommunityUsers.Add((CommunityUserEntity)relatedEntity);
					break;
				case "CommunityUsers1":
					this.CommunityUsers1.Add((CommunityUserEntity)relatedEntity);
					break;
				case "CommunityUsers2":
					this.CommunityUsers2.Add((CommunityUserEntity)relatedEntity);
					break;
				case "Posts":
					this.Posts.Add((PostEntity)relatedEntity);
					break;
				case "Posts1":
					this.Posts1.Add((PostEntity)relatedEntity);
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
				case "Company":
					DesetupSyncCompany(false, true);
					break;
				case "Person":
					DesetupSyncPerson(false, true);
					break;
				case "Communities":
					this.PerformRelatedEntityRemoval(this.Communities, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Communities1":
					this.PerformRelatedEntityRemoval(this.Communities1, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Communities2":
					this.PerformRelatedEntityRemoval(this.Communities2, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CommunityUsers":
					this.PerformRelatedEntityRemoval(this.CommunityUsers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CommunityUsers1":
					this.PerformRelatedEntityRemoval(this.CommunityUsers1, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CommunityUsers2":
					this.PerformRelatedEntityRemoval(this.CommunityUsers2, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Posts":
					this.PerformRelatedEntityRemoval(this.Posts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Posts1":
					this.PerformRelatedEntityRemoval(this.Posts1, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_company!=null)
			{
				toReturn.Add(_company);
			}
			if(_person!=null)
			{
				toReturn.Add(_person);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.Communities);
			toReturn.Add(this.Communities1);
			toReturn.Add(this.Communities2);
			toReturn.Add(this.CommunityUsers);
			toReturn.Add(this.CommunityUsers1);
			toReturn.Add(this.CommunityUsers2);
			toReturn.Add(this.Posts);
			toReturn.Add(this.Posts1);
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
				info.AddValue("_communities", ((_communities!=null) && (_communities.Count>0) && !this.MarkedForDeletion)?_communities:null);
				info.AddValue("_communities1", ((_communities1!=null) && (_communities1.Count>0) && !this.MarkedForDeletion)?_communities1:null);
				info.AddValue("_communities2", ((_communities2!=null) && (_communities2.Count>0) && !this.MarkedForDeletion)?_communities2:null);
				info.AddValue("_communityUsers", ((_communityUsers!=null) && (_communityUsers.Count>0) && !this.MarkedForDeletion)?_communityUsers:null);
				info.AddValue("_communityUsers1", ((_communityUsers1!=null) && (_communityUsers1.Count>0) && !this.MarkedForDeletion)?_communityUsers1:null);
				info.AddValue("_communityUsers2", ((_communityUsers2!=null) && (_communityUsers2.Count>0) && !this.MarkedForDeletion)?_communityUsers2:null);
				info.AddValue("_posts", ((_posts!=null) && (_posts.Count>0) && !this.MarkedForDeletion)?_posts:null);
				info.AddValue("_posts1", ((_posts1!=null) && (_posts1.Count>0) && !this.MarkedForDeletion)?_posts1:null);
				info.AddValue("_company", (!this.MarkedForDeletion?_company:null));
				info.AddValue("_person", (!this.MarkedForDeletion?_person:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new UserRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Community' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCommunities()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CommunityFields.CreatedByUserId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Community' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCommunities1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CommunityFields.LastModifiedByUserId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Community' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCommunities2()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CommunityFields.ManagerId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CommunityUser' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCommunityUsers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CommunityUserFields.CreatedByUserId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CommunityUser' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCommunityUsers1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CommunityUserFields.LastModifiedByUserId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CommunityUser' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCommunityUsers2()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CommunityUserFields.UserId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Post' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPosts()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PostFields.CreatedByUserId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Post' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPosts1()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PostFields.LastModifiedByUserId, null, ComparisonOperator.Equal, this.Id));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Company' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCompany()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CompanyFields.Id, null, ComparisonOperator.Equal, this.CompanyId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPerson()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PersonFields.Id, null, ComparisonOperator.Equal, this.PersonId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory));
		}

		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._communities);
			collectionsQueue.Enqueue(this._communities1);
			collectionsQueue.Enqueue(this._communities2);
			collectionsQueue.Enqueue(this._communityUsers);
			collectionsQueue.Enqueue(this._communityUsers1);
			collectionsQueue.Enqueue(this._communityUsers2);
			collectionsQueue.Enqueue(this._posts);
			collectionsQueue.Enqueue(this._posts1);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._communities = (EntityCollection<CommunityEntity>) collectionsQueue.Dequeue();
			this._communities1 = (EntityCollection<CommunityEntity>) collectionsQueue.Dequeue();
			this._communities2 = (EntityCollection<CommunityEntity>) collectionsQueue.Dequeue();
			this._communityUsers = (EntityCollection<CommunityUserEntity>) collectionsQueue.Dequeue();
			this._communityUsers1 = (EntityCollection<CommunityUserEntity>) collectionsQueue.Dequeue();
			this._communityUsers2 = (EntityCollection<CommunityUserEntity>) collectionsQueue.Dequeue();
			this._posts = (EntityCollection<PostEntity>) collectionsQueue.Dequeue();
			this._posts1 = (EntityCollection<PostEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._communities != null);
			toReturn |=(this._communities1 != null);
			toReturn |=(this._communities2 != null);
			toReturn |=(this._communityUsers != null);
			toReturn |=(this._communityUsers1 != null);
			toReturn |=(this._communityUsers2 != null);
			toReturn |=(this._posts != null);
			toReturn |=(this._posts1 != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CommunityEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CommunityEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CommunityEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CommunityUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityUserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CommunityUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityUserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CommunityUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityUserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory))) : null);
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Company", _company);
			toReturn.Add("Person", _person);
			toReturn.Add("Communities", _communities);
			toReturn.Add("Communities1", _communities1);
			toReturn.Add("Communities2", _communities2);
			toReturn.Add("CommunityUsers", _communityUsers);
			toReturn.Add("CommunityUsers1", _communityUsers1);
			toReturn.Add("CommunityUsers2", _communityUsers2);
			toReturn.Add("Posts", _posts);
			toReturn.Add("Posts1", _posts1);
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
			_fieldsCustomProperties.Add("CompanyId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsConfirmed", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Password", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PersonId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserName", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _company</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCompany(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _company, new PropertyChangedEventHandler( OnCompanyPropertyChanged ), "Company", Let3arafo.Data.RelationClasses.StaticUserRelations.CompanyEntityUsingCompanyIdStatic, true, signalRelatedEntity, "Users", resetFKFields, new int[] { (int)UserFieldIndex.CompanyId } );
			_company = null;
		}

		/// <summary> setups the sync logic for member _company</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCompany(IEntityCore relatedEntity)
		{
			if(_company!=relatedEntity)
			{
				DesetupSyncCompany(true, true);
				_company = (CompanyEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _company, new PropertyChangedEventHandler( OnCompanyPropertyChanged ), "Company", Let3arafo.Data.RelationClasses.StaticUserRelations.CompanyEntityUsingCompanyIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCompanyPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _person</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPerson(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _person, new PropertyChangedEventHandler( OnPersonPropertyChanged ), "Person", Let3arafo.Data.RelationClasses.StaticUserRelations.PersonEntityUsingPersonIdStatic, true, signalRelatedEntity, "Users", resetFKFields, new int[] { (int)UserFieldIndex.PersonId } );
			_person = null;
		}

		/// <summary> setups the sync logic for member _person</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPerson(IEntityCore relatedEntity)
		{
			if(_person!=relatedEntity)
			{
				DesetupSyncPerson(true, true);
				_person = (PersonEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _person, new PropertyChangedEventHandler( OnPersonPropertyChanged ), "Person", Let3arafo.Data.RelationClasses.StaticUserRelations.PersonEntityUsingPersonIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPersonPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this UserEntity</param>
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
		public  static UserRelations Relations
		{
			get	{ return new UserRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Community' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCommunities
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CommunityEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityEntityFactory))), (IEntityRelation)GetRelationsForField("Communities")[0], (int)Let3arafo.Data.EntityType.UserEntity, (int)Let3arafo.Data.EntityType.CommunityEntity, 0, null, null, null, null, "Communities", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Community' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCommunities1
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CommunityEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityEntityFactory))), (IEntityRelation)GetRelationsForField("Communities1")[0], (int)Let3arafo.Data.EntityType.UserEntity, (int)Let3arafo.Data.EntityType.CommunityEntity, 0, null, null, null, null, "Communities1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Community' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCommunities2
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CommunityEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityEntityFactory))), (IEntityRelation)GetRelationsForField("Communities2")[0], (int)Let3arafo.Data.EntityType.UserEntity, (int)Let3arafo.Data.EntityType.CommunityEntity, 0, null, null, null, null, "Communities2", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CommunityUser' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCommunityUsers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CommunityUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityUserEntityFactory))), (IEntityRelation)GetRelationsForField("CommunityUsers")[0], (int)Let3arafo.Data.EntityType.UserEntity, (int)Let3arafo.Data.EntityType.CommunityUserEntity, 0, null, null, null, null, "CommunityUsers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CommunityUser' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCommunityUsers1
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CommunityUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityUserEntityFactory))), (IEntityRelation)GetRelationsForField("CommunityUsers1")[0], (int)Let3arafo.Data.EntityType.UserEntity, (int)Let3arafo.Data.EntityType.CommunityUserEntity, 0, null, null, null, null, "CommunityUsers1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CommunityUser' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCommunityUsers2
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CommunityUserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CommunityUserEntityFactory))), (IEntityRelation)GetRelationsForField("CommunityUsers2")[0], (int)Let3arafo.Data.EntityType.UserEntity, (int)Let3arafo.Data.EntityType.CommunityUserEntity, 0, null, null, null, null, "CommunityUsers2", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Post' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPosts
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory))), (IEntityRelation)GetRelationsForField("Posts")[0], (int)Let3arafo.Data.EntityType.UserEntity, (int)Let3arafo.Data.EntityType.PostEntity, 0, null, null, null, null, "Posts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Post' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPosts1
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PostEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PostEntityFactory))), (IEntityRelation)GetRelationsForField("Posts1")[0], (int)Let3arafo.Data.EntityType.UserEntity, (int)Let3arafo.Data.EntityType.PostEntity, 0, null, null, null, null, "Posts1", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Company' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCompany
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CompanyEntityFactory))),	(IEntityRelation)GetRelationsForField("Company")[0], (int)Let3arafo.Data.EntityType.UserEntity, (int)Let3arafo.Data.EntityType.CompanyEntity, 0, null, null, null, null, "Company", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PersonEntityFactory))),	(IEntityRelation)GetRelationsForField("Person")[0], (int)Let3arafo.Data.EntityType.UserEntity, (int)Let3arafo.Data.EntityType.PersonEntity, 0, null, null, null, null, "Person", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CompanyId property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."CompanyId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CompanyId
		{
			get { return (Nullable<System.Int32>)GetValue((int)UserFieldIndex.CompanyId, false); }
			set	{ SetValue((int)UserFieldIndex.CompanyId, value); }
		}

		/// <summary> The Id property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)UserFieldIndex.Id, true); }
			set	{ SetValue((int)UserFieldIndex.Id, value); }
		}

		/// <summary> The IsActive property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsActive, true); }
			set	{ SetValue((int)UserFieldIndex.IsActive, value); }
		}

		/// <summary> The IsConfirmed property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."IsConfirmed"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsConfirmed
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsConfirmed, true); }
			set	{ SetValue((int)UserFieldIndex.IsConfirmed, value); }
		}

		/// <summary> The Password property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 1000<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Password
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Password, true); }
			set	{ SetValue((int)UserFieldIndex.Password, value); }
		}

		/// <summary> The PersonId property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."PersonId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> PersonId
		{
			get { return (Nullable<System.Int32>)GetValue((int)UserFieldIndex.PersonId, false); }
			set	{ SetValue((int)UserFieldIndex.PersonId, value); }
		}

		/// <summary> The UserName property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."UserName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String UserName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.UserName, true); }
			set	{ SetValue((int)UserFieldIndex.UserName, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CommunityEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CommunityEntity))]
		public virtual EntityCollection<CommunityEntity> Communities
		{
			get { return GetOrCreateEntityCollection<CommunityEntity, CommunityEntityFactory>("User", true, false, ref _communities);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CommunityEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CommunityEntity))]
		public virtual EntityCollection<CommunityEntity> Communities1
		{
			get { return GetOrCreateEntityCollection<CommunityEntity, CommunityEntityFactory>("User1", true, false, ref _communities1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CommunityEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CommunityEntity))]
		public virtual EntityCollection<CommunityEntity> Communities2
		{
			get { return GetOrCreateEntityCollection<CommunityEntity, CommunityEntityFactory>("User2", true, false, ref _communities2);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CommunityUserEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CommunityUserEntity))]
		public virtual EntityCollection<CommunityUserEntity> CommunityUsers
		{
			get { return GetOrCreateEntityCollection<CommunityUserEntity, CommunityUserEntityFactory>("User", true, false, ref _communityUsers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CommunityUserEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CommunityUserEntity))]
		public virtual EntityCollection<CommunityUserEntity> CommunityUsers1
		{
			get { return GetOrCreateEntityCollection<CommunityUserEntity, CommunityUserEntityFactory>("User1", true, false, ref _communityUsers1);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CommunityUserEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CommunityUserEntity))]
		public virtual EntityCollection<CommunityUserEntity> CommunityUsers2
		{
			get { return GetOrCreateEntityCollection<CommunityUserEntity, CommunityUserEntityFactory>("User2", true, false, ref _communityUsers2);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PostEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PostEntity))]
		public virtual EntityCollection<PostEntity> Posts
		{
			get { return GetOrCreateEntityCollection<PostEntity, PostEntityFactory>("User", true, false, ref _posts);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PostEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PostEntity))]
		public virtual EntityCollection<PostEntity> Posts1
		{
			get { return GetOrCreateEntityCollection<PostEntity, PostEntityFactory>("User1", true, false, ref _posts1);	}
		}

		/// <summary> Gets / sets related entity of type 'CompanyEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CompanyEntity Company
		{
			get	{ return _company; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCompany(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Users", "Company", _company, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'PersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get	{ return _person; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPerson(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Users", "Person", _person, true); 
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
			get { return (int)Let3arafo.Data.EntityType.UserEntity; }
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
