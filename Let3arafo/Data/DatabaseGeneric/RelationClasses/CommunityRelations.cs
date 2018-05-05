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
	/// <summary>Implements the relations factory for the entity: Community. </summary>
	public partial class CommunityRelations
	{
		/// <summary>CTor</summary>
		public CommunityRelations()
		{
		}

		/// <summary>Gets all relations of the CommunityEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CommunityUserEntityUsingCommunityId);
			toReturn.Add(this.CommunityCategoryEntityUsingCategoryId);
			toReturn.Add(this.UserEntityUsingCreatedByUserId);
			toReturn.Add(this.UserEntityUsingLastModifiedByUserId);
			toReturn.Add(this.UserEntityUsingManagerId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CommunityEntity and CommunityUserEntity over the 1:n relation they have, using the relation between the fields:
		/// Community.Id - CommunityUser.CommunityId
		/// </summary>
		public virtual IEntityRelation CommunityUserEntityUsingCommunityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CommunityUsers" , true);
				relation.AddEntityFieldPair(CommunityFields.Id, CommunityUserFields.CommunityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityUserEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between CommunityEntity and CommunityCategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// Community.CategoryId - CommunityCategory.Id
		/// </summary>
		public virtual IEntityRelation CommunityCategoryEntityUsingCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CommunityCategory", false);
				relation.AddEntityFieldPair(CommunityCategoryFields.Id, CommunityFields.CategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityCategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CommunityEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// Community.CreatedByUserId - User.Id
		/// </summary>
		public virtual IEntityRelation UserEntityUsingCreatedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.Id, CommunityFields.CreatedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CommunityEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// Community.LastModifiedByUserId - User.Id
		/// </summary>
		public virtual IEntityRelation UserEntityUsingLastModifiedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User1", false);
				relation.AddEntityFieldPair(UserFields.Id, CommunityFields.LastModifiedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CommunityEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// Community.ManagerId - User.Id
		/// </summary>
		public virtual IEntityRelation UserEntityUsingManagerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User2", false);
				relation.AddEntityFieldPair(UserFields.Id, CommunityFields.ManagerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommunityEntity", true);
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
	internal static class StaticCommunityRelations
	{
		internal static readonly IEntityRelation CommunityUserEntityUsingCommunityIdStatic = new CommunityRelations().CommunityUserEntityUsingCommunityId;
		internal static readonly IEntityRelation CommunityCategoryEntityUsingCategoryIdStatic = new CommunityRelations().CommunityCategoryEntityUsingCategoryId;
		internal static readonly IEntityRelation UserEntityUsingCreatedByUserIdStatic = new CommunityRelations().UserEntityUsingCreatedByUserId;
		internal static readonly IEntityRelation UserEntityUsingLastModifiedByUserIdStatic = new CommunityRelations().UserEntityUsingLastModifiedByUserId;
		internal static readonly IEntityRelation UserEntityUsingManagerIdStatic = new CommunityRelations().UserEntityUsingManagerId;

		/// <summary>CTor</summary>
		static StaticCommunityRelations()
		{
		}
	}
}
