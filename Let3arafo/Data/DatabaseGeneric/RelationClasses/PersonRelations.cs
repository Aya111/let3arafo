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
	/// <summary>Implements the relations factory for the entity: Person. </summary>
	public partial class PersonRelations
	{
		/// <summary>CTor</summary>
		public PersonRelations()
		{
		}

		/// <summary>Gets all relations of the PersonEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.UserEntityUsingPersonId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and UserEntity over the 1:n relation they have, using the relation between the fields:
		/// Person.Id - User.PersonId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingPersonId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Users" , true);
				relation.AddEntityFieldPair(PersonFields.Id, UserFields.PersonId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
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
	internal static class StaticPersonRelations
	{
		internal static readonly IEntityRelation UserEntityUsingPersonIdStatic = new PersonRelations().UserEntityUsingPersonId;

		/// <summary>CTor</summary>
		static StaticPersonRelations()
		{
		}
	}
}
