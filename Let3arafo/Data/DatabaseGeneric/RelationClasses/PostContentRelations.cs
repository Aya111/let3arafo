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
	/// <summary>Implements the relations factory for the entity: PostContent. </summary>
	public partial class PostContentRelations
	{
		/// <summary>CTor</summary>
		public PostContentRelations()
		{
		}

		/// <summary>Gets all relations of the PostContentEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PostContentEntityUsingPostId);
			toReturn.Add(this.PostContentEntityUsingIdPostId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PostContentEntity and PostContentEntity over the 1:n relation they have, using the relation between the fields:
		/// PostContent.Id - PostContent.PostId
		/// </summary>
		public virtual IEntityRelation PostContentEntityUsingPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PostContents" , true);
				relation.AddEntityFieldPair(PostContentFields.Id, PostContentFields.PostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostContentEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostContentEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PostContentEntity and PostContentEntity over the m:1 relation they have, using the relation between the fields:
		/// PostContent.PostId - PostContent.Id
		/// </summary>
		public virtual IEntityRelation PostContentEntityUsingIdPostId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PostContent", false);
				relation.AddEntityFieldPair(PostContentFields.Id, PostContentFields.PostId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostContentEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PostContentEntity", true);
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
	internal static class StaticPostContentRelations
	{
		internal static readonly IEntityRelation PostContentEntityUsingPostIdStatic = new PostContentRelations().PostContentEntityUsingPostId;
		internal static readonly IEntityRelation PostContentEntityUsingIdPostIdStatic = new PostContentRelations().PostContentEntityUsingIdPostId;

		/// <summary>CTor</summary>
		static StaticPostContentRelations()
		{
		}
	}
}
