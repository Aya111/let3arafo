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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Let3arafo.Data.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitCommunityEntityInfos();
			InitCommunityCategoryEntityInfos();
			InitCommunityUserEntityInfos();
			InitCompanyEntityInfos();
			InitPersonEntityInfos();
			InitPostEntityInfos();
			InitPostContentEntityInfos();
			InitUserEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits CommunityEntity's FieldInfo objects</summary>
		private void InitCommunityEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CommunityFieldIndex), "CommunityEntity");
			this.AddElementFieldInfo("CommunityEntity", "CategoryId", typeof(System.Int32), false, true, false, false,  (int)CommunityFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("CommunityEntity", "CommunityName", typeof(System.String), false, false, false, false,  (int)CommunityFieldIndex.CommunityName, 100, 0, 0);
			this.AddElementFieldInfo("CommunityEntity", "CreatedByUserId", typeof(System.Int32), false, true, false, false,  (int)CommunityFieldIndex.CreatedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("CommunityEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)CommunityFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("CommunityEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)CommunityFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("CommunityEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)CommunityFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("CommunityEntity", "IsAgreed", typeof(System.Boolean), false, false, false, false,  (int)CommunityFieldIndex.IsAgreed, 0, 0, 0);
			this.AddElementFieldInfo("CommunityEntity", "LastModified", typeof(System.DateTime), false, false, false, false,  (int)CommunityFieldIndex.LastModified, 0, 0, 0);
			this.AddElementFieldInfo("CommunityEntity", "LastModifiedByUserId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CommunityFieldIndex.LastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("CommunityEntity", "ManagerId", typeof(System.Int32), false, true, false, false,  (int)CommunityFieldIndex.ManagerId, 0, 0, 10);
		}
		/// <summary>Inits CommunityCategoryEntity's FieldInfo objects</summary>
		private void InitCommunityCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CommunityCategoryFieldIndex), "CommunityCategoryEntity");
			this.AddElementFieldInfo("CommunityCategoryEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)CommunityCategoryFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("CommunityCategoryEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)CommunityCategoryFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("CommunityCategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)CommunityCategoryFieldIndex.Name, 1000, 0, 0);
		}
		/// <summary>Inits CommunityUserEntity's FieldInfo objects</summary>
		private void InitCommunityUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CommunityUserFieldIndex), "CommunityUserEntity");
			this.AddElementFieldInfo("CommunityUserEntity", "CommunityId", typeof(System.Int32), false, true, false, false,  (int)CommunityUserFieldIndex.CommunityId, 0, 0, 10);
			this.AddElementFieldInfo("CommunityUserEntity", "CreatedByUserId", typeof(System.Int32), false, true, false, false,  (int)CommunityUserFieldIndex.CreatedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("CommunityUserEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)CommunityUserFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("CommunityUserEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)CommunityUserFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("CommunityUserEntity", "LastModified", typeof(System.DateTime), false, false, false, false,  (int)CommunityUserFieldIndex.LastModified, 0, 0, 0);
			this.AddElementFieldInfo("CommunityUserEntity", "LastModifiedByUserId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CommunityUserFieldIndex.LastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("CommunityUserEntity", "UserId", typeof(System.Int32), false, true, false, false,  (int)CommunityUserFieldIndex.UserId, 0, 0, 10);
		}
		/// <summary>Inits CompanyEntity's FieldInfo objects</summary>
		private void InitCompanyEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CompanyFieldIndex), "CompanyEntity");
			this.AddElementFieldInfo("CompanyEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)CompanyFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("CompanyEntity", "Name", typeof(System.String), false, false, false, false,  (int)CompanyFieldIndex.Name, 100, 0, 0);
		}
		/// <summary>Inits PersonEntity's FieldInfo objects</summary>
		private void InitPersonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PersonFieldIndex), "PersonEntity");
			this.AddElementFieldInfo("PersonEntity", "BirthDate", typeof(System.DateTime), false, false, false, false,  (int)PersonFieldIndex.BirthDate, 0, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Gender", typeof(System.Int16), false, false, false, false,  (int)PersonFieldIndex.Gender, 0, 0, 5);
			this.AddElementFieldInfo("PersonEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PersonFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PersonEntity", "IdScanPath", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.IdScanPath, 1000, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "NationalId", typeof(System.Int64), false, false, false, false,  (int)PersonFieldIndex.NationalId, 0, 0, 19);
			this.AddElementFieldInfo("PersonEntity", "RestOfName", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.RestOfName, 100, 0, 0);
		}
		/// <summary>Inits PostEntity's FieldInfo objects</summary>
		private void InitPostEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PostFieldIndex), "PostEntity");
			this.AddElementFieldInfo("PostEntity", "CreatedByUserId", typeof(System.Int32), false, true, false, false,  (int)PostFieldIndex.CreatedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("PostEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)PostFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("PostEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PostFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PostEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)PostFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("PostEntity", "LastModified", typeof(System.DateTime), false, false, false, false,  (int)PostFieldIndex.LastModified, 0, 0, 0);
			this.AddElementFieldInfo("PostEntity", "LastModifiedByUserId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)PostFieldIndex.LastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("PostEntity", "Text", typeof(System.String), false, false, false, false,  (int)PostFieldIndex.Text, 2147483647, 0, 0);
		}
		/// <summary>Inits PostContentEntity's FieldInfo objects</summary>
		private void InitPostContentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PostContentFieldIndex), "PostContentEntity");
			this.AddElementFieldInfo("PostContentEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PostContentFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PostContentEntity", "MimeType", typeof(System.String), false, false, false, false,  (int)PostContentFieldIndex.MimeType, 50, 0, 0);
			this.AddElementFieldInfo("PostContentEntity", "Path", typeof(System.String), false, false, false, false,  (int)PostContentFieldIndex.Path, 1000, 0, 0);
			this.AddElementFieldInfo("PostContentEntity", "PostId", typeof(System.Int32), false, true, false, false,  (int)PostContentFieldIndex.PostId, 0, 0, 10);
		}
		/// <summary>Inits UserEntity's FieldInfo objects</summary>
		private void InitUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "CompanyId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)UserFieldIndex.CompanyId, 0, 0, 10);
			this.AddElementFieldInfo("UserEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)UserFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("UserEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)UserFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "IsConfirmed", typeof(System.Boolean), false, false, false, false,  (int)UserFieldIndex.IsConfirmed, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 1000, 0, 0);
			this.AddElementFieldInfo("UserEntity", "PersonId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)UserFieldIndex.PersonId, 0, 0, 10);
			this.AddElementFieldInfo("UserEntity", "UserName", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.UserName, 100, 0, 0);
		}
		
	}
}




