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
using System.Collections;
using System.Collections.Generic;
using Let3arafo.Data;
using Let3arafo.Data.FactoryClasses;
using Let3arafo.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Let3arafo.Data.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: User. </summary>
	public partial class UserRelations
	{
		/// <summary>CTor</summary>
		public UserRelations()
		{
		}

		/// <summary>Gets all relations of the UserEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CommunityEntityUsingCreatedByUserId);
			toReturn.Add(this.CommunityEntityUsingLastModifiedByUserId);
			toReturn.Add(this.CommunityEntityUsingManagerId);
			toReturn.Add(this.CommunityUserEntityUsingCreatedByUserId);
			toReturn.Add(this.CommunityUserEntityUsingLastModifiedByUserId);
			toReturn.Add(this.CommunityUserEntityUsingUserId);
			toReturn.Add(this.PostEntityUsingCreatedByUserId);
			toReturn.Add(this.PostEntityUsingLastModifiedByUserId);
			toReturn.Add(this.CompanyEntityUsingCompanyId);
			toReturn.Add(this.PersonEntityUsingPersonId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between UserEntity and CommunityEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - Community.CreatedByUserId
		/// </summary>
		public virtual IEntityRelation CommunityEntityUsingCreatedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Communities" , true);
				relation.AddEntityFieldPair(UserFields.Id, CommunityFields.CreatedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and CommunityEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - Community.LastModifiedByUserId
		/// </summary>
		public virtual IEntityRelation CommunityEntityUsingLastModifiedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Communities1" , true);
				relation.AddEntityFieldPair(UserFields.Id, CommunityFields.LastModifiedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and CommunityEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - Community.ManagerId
		/// </summary>
		public virtual IEntityRelation CommunityEntityUsingManagerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Communities2" , true);
				relation.AddEntityFieldPair(UserFields.Id, CommunityFields.ManagerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and CommunityUserEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - CommunityUser.CreatedByUserId
		/// </summary>
		public virtual IEntityRelation CommunityUserEntityUsingCreatedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CommunityUsers" , true);
				relation.AddEntityFieldPair(UserFields.Id, CommunityUserFields.CreatedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityUserEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and CommunityUserEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - CommunityUser.LastModifiedByUserId
		/// </summary>
		public virtual IEntityRelation CommunityUserEntityUsingLastModifiedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CommunityUsers1" , true);
				relation.AddEntityFieldPair(UserFields.Id, CommunityUserFields.LastModifiedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityUserEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and CommunityUserEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - CommunityUser.UserId
		/// </summary>
		public virtual IEntityRelation CommunityUserEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CommunityUsers2" , true);
				relation.AddEntityFieldPair(UserFields.Id, CommunityUserFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityUserEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and PostEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - Post.CreatedByUserId
		/// </summary>
		public virtual IEntityRelation PostEntityUsingCreatedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Posts" , true);
				relation.AddEntityFieldPair(UserFields.Id, PostFields.CreatedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and PostEntity over the 1:n relation they have, using the relation between the fields:
		/// User.Id - Post.LastModifiedByUserId
		/// </summary>
		public virtual IEntityRelation PostEntityUsingLastModifiedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Posts1" , true);
				relation.AddEntityFieldPair(UserFields.Id, PostFields.LastModifiedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between UserEntity and CompanyEntity over the m:1 relation they have, using the relation between the fields:
		/// User.CompanyId - Company.Id
		/// </summary>
		public virtual IEntityRelation CompanyEntityUsingCompanyId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Company", false);
				relation.AddEntityFieldPair(CompanyFields.Id, UserFields.CompanyId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CompanyEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between UserEntity and PersonEntity over the m:1 relation they have, using the relation between the fields:
		/// User.PersonId - Person.Id
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingPersonId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Person", false);
				relation.AddEntityFieldPair(PersonFields.Id, UserFields.PersonId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticUserRelations
	{
		internal static readonly IEntityRelation CommunityEntityUsingCreatedByUserIdStatic = new UserRelations().CommunityEntityUsingCreatedByUserId;
		internal static readonly IEntityRelation CommunityEntityUsingLastModifiedByUserIdStatic = new UserRelations().CommunityEntityUsingLastModifiedByUserId;
		internal static readonly IEntityRelation CommunityEntityUsingManagerIdStatic = new UserRelations().CommunityEntityUsingManagerId;
		internal static readonly IEntityRelation CommunityUserEntityUsingCreatedByUserIdStatic = new UserRelations().CommunityUserEntityUsingCreatedByUserId;
		internal static readonly IEntityRelation CommunityUserEntityUsingLastModifiedByUserIdStatic = new UserRelations().CommunityUserEntityUsingLastModifiedByUserId;
		internal static readonly IEntityRelation CommunityUserEntityUsingUserIdStatic = new UserRelations().CommunityUserEntityUsingUserId;
		internal static readonly IEntityRelation PostEntityUsingCreatedByUserIdStatic = new UserRelations().PostEntityUsingCreatedByUserId;
		internal static readonly IEntityRelation PostEntityUsingLastModifiedByUserIdStatic = new UserRelations().PostEntityUsingLastModifiedByUserId;
		internal static readonly IEntityRelation CompanyEntityUsingCompanyIdStatic = new UserRelations().CompanyEntityUsingCompanyId;
		internal static readonly IEntityRelation PersonEntityUsingPersonIdStatic = new UserRelations().PersonEntityUsingPersonId;

		/// <summary>CTor</summary>
		static StaticUserRelations()
		{
		}
	}
}
