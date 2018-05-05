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
	/// <summary>Implements the relations factory for the entity: Post. </summary>
	public partial class PostRelations
	{
		/// <summary>CTor</summary>
		public PostRelations()
		{
		}

		/// <summary>Gets all relations of the PostEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.UserEntityUsingCreatedByUserId);
			toReturn.Add(this.UserEntityUsingLastModifiedByUserId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between PostEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// Post.CreatedByUserId - User.Id
		/// </summary>
		public virtual IEntityRelation UserEntityUsingCreatedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.Id, PostFields.CreatedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PostEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// Post.LastModifiedByUserId - User.Id
		/// </summary>
		public virtual IEntityRelation UserEntityUsingLastModifiedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User1", false);
				relation.AddEntityFieldPair(UserFields.Id, PostFields.LastModifiedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostEntity", true);
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
	internal static class StaticPostRelations
	{
		internal static readonly IEntityRelation UserEntityUsingCreatedByUserIdStatic = new PostRelations().UserEntityUsingCreatedByUserId;
		internal static readonly IEntityRelation UserEntityUsingLastModifiedByUserIdStatic = new PostRelations().UserEntityUsingLastModifiedByUserId;

		/// <summary>CTor</summary>
		static StaticPostRelations()
		{
		}
	}
}
