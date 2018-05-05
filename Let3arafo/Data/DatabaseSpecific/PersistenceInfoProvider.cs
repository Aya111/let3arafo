///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Let3arafo.Data.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitCommunityEntityMappings();
			InitCommunityCategoryEntityMappings();
			InitCommunityUserEntityMappings();
			InitCompanyEntityMappings();
			InitPersonEntityMappings();
			InitPostEntityMappings();
			InitPostContentEntityMappings();
			InitUserEntityMappings();
		}

		/// <summary>Inits CommunityEntity's mappings</summary>
		private void InitCommunityEntityMappings()
		{
			this.AddElementMapping("CommunityEntity", @"Let3arafo", @"dbo", "Community", 10, 0);
			this.AddElementFieldMapping("CommunityEntity", "CategoryId", "CategoryId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CommunityEntity", "CommunityName", "CommunityName", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CommunityEntity", "CreatedByUserId", "CreatedByUserId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("CommunityEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("CommunityEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("CommunityEntity", "IsActive", "IsActive", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5);
			this.AddElementFieldMapping("CommunityEntity", "IsAgreed", "IsAgreed", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("CommunityEntity", "LastModified", "LastModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("CommunityEntity", "LastModifiedByUserId", "LastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("CommunityEntity", "ManagerId", "ManagerId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 9);
		}

		/// <summary>Inits CommunityCategoryEntity's mappings</summary>
		private void InitCommunityCategoryEntityMappings()
		{
			this.AddElementMapping("CommunityCategoryEntity", @"Let3arafo", @"dbo", "CommunityCategory", 3, 0);
			this.AddElementFieldMapping("CommunityCategoryEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CommunityCategoryEntity", "IsActive", "IsActive", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1);
			this.AddElementFieldMapping("CommunityCategoryEntity", "Name", "Name", false, "NVarChar", 1000, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits CommunityUserEntity's mappings</summary>
		private void InitCommunityUserEntityMappings()
		{
			this.AddElementMapping("CommunityUserEntity", @"Let3arafo", @"dbo", "CommunityUser", 7, 0);
			this.AddElementFieldMapping("CommunityUserEntity", "CommunityId", "CommunityId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CommunityUserEntity", "CreatedByUserId", "CreatedByUserId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("CommunityUserEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("CommunityUserEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("CommunityUserEntity", "LastModified", "LastModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("CommunityUserEntity", "LastModifiedByUserId", "LastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("CommunityUserEntity", "UserId", "UserId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
		}

		/// <summary>Inits CompanyEntity's mappings</summary>
		private void InitCompanyEntityMappings()
		{
			this.AddElementMapping("CompanyEntity", @"Let3arafo", @"dbo", "Company", 2, 0);
			this.AddElementFieldMapping("CompanyEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CompanyEntity", "Name", "Name", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1);
		}

		/// <summary>Inits PersonEntity's mappings</summary>
		private void InitPersonEntityMappings()
		{
			this.AddElementMapping("PersonEntity", @"Let3arafo", @"dbo", "Person", 7, 0);
			this.AddElementFieldMapping("PersonEntity", "BirthDate", "BirthDate", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("PersonEntity", "FirstName", "FirstName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("PersonEntity", "Gender", "Gender", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 2);
			this.AddElementFieldMapping("PersonEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("PersonEntity", "IdScanPath", "IdScanPath", false, "NVarChar", 1000, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("PersonEntity", "NationalId", "NationalId", false, "BigInt", 0, 19, 0, false, "", null, typeof(System.Int64), 5);
			this.AddElementFieldMapping("PersonEntity", "RestOfName", "RestOfName", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 6);
		}

		/// <summary>Inits PostEntity's mappings</summary>
		private void InitPostEntityMappings()
		{
			this.AddElementMapping("PostEntity", @"Let3arafo", @"dbo", "Post", 7, 0);
			this.AddElementFieldMapping("PostEntity", "CreatedByUserId", "CreatedByUserId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("PostEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("PostEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("PostEntity", "IsActive", "IsActive", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3);
			this.AddElementFieldMapping("PostEntity", "LastModified", "LastModified", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("PostEntity", "LastModifiedByUserId", "LastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("PostEntity", "Text", "Text", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 6);
		}

		/// <summary>Inits PostContentEntity's mappings</summary>
		private void InitPostContentEntityMappings()
		{
			this.AddElementMapping("PostContentEntity", @"Let3arafo", @"dbo", "PostContent", 4, 0);
			this.AddElementFieldMapping("PostContentEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("PostContentEntity", "MimeType", "MimeType", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("PostContentEntity", "Path", "Path", false, "NVarChar", 1000, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("PostContentEntity", "PostId", "PostId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping("UserEntity", @"Let3arafo", @"dbo", "User", 7, 0);
			this.AddElementFieldMapping("UserEntity", "CompanyId", "CompanyId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("UserEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("UserEntity", "IsActive", "IsActive", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2);
			this.AddElementFieldMapping("UserEntity", "IsConfirmed", "IsConfirmed", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3);
			this.AddElementFieldMapping("UserEntity", "Password", "Password", false, "NVarChar", 1000, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("UserEntity", "PersonId", "PersonId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("UserEntity", "UserName", "UserName", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 6);
		}

	}
}
