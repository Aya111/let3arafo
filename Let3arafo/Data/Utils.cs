using FluentMigrator.Builders.Alter.Table;
using FluentMigrator.Builders.Create.Table;

namespace Let3arafo.Migration
{
    internal class StringLength
    {
        public const int _50 = 50;
        public const int _100 = 100;
        public const int _250 = 250;
        public const int _500 = 500;
        public const int _1000 = 1000;
        public const int _10K = 10_000;
        public const int _30K = 30_000;
    }

    internal static class Tables
    {
        public const string Community= "Community";
        public const string CommunityCategory = "CommunityCategory";
        public const string CommunityUser = "CommunityUser";
        public const string Company = "Company";
        public const string Person = "Person";
        public const string Post = "Post";
        public const string PostContent = "PostContent";
        public const string User = "User";

    }

    internal static class FluentMigratorExtensions
    {
        /// <summary>
        /// Ordinary Changeinfo with relations
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static ICreateTableWithColumnOrSchemaSyntax ChangeInfo(this ICreateTableWithColumnOrSchemaSyntax self)
        {
            self.WithColumn("DateCreated").AsDateTime().NotNullable().WithDefaultValue(new SQLServerFunction("getutcdate()"))
                 .WithColumn("CreatedByUserId").AsInt32().NotNullable().ForeignKey(Tables.User, "Id").Indexed()
                 .WithColumn("LastModified").AsDateTime().NotNullable().WithDefaultValue(new SQLServerFunction("getutcdate()"))
                 .WithColumn("LastModifiedByUserId").AsInt32().Nullable().ForeignKey(Tables.User, "Id").Indexed();

            return self;
        }

        public static ICreateTableWithColumnOrSchemaSyntax AutoId(this ICreateTableWithColumnOrSchemaSyntax self)
        {
            self.WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey();
            return self;
        }

        public static ICreateTableWithColumnOrSchemaSyntax IntId(this ICreateTableWithColumnOrSchemaSyntax self)
        {
            self.WithColumn("Id").AsInt32().NotNullable().PrimaryKey();
            return self;
        }

        public static ICreateTableWithColumnOrSchemaSyntax IntForeignKey(this ICreateTableWithColumnOrSchemaSyntax self,
                string name, string foreignTable, bool isNullable, bool isUnique = false, bool isPK = false, bool onDeleteCascade = false)
        {
            ICreateTableColumnOptionOrWithColumnSyntax col;

            var rule = onDeleteCascade ? System.Data.Rule.Cascade : System.Data.Rule.None;

            if (isUnique)
            {
                col = self.WithColumn(name).AsInt32().ForeignKey(foreignTable, "Id").OnDelete(rule).Unique();
            }
            else
            {
                col = self.WithColumn(name).AsInt32().ForeignKey(foreignTable, "Id").OnDelete(rule);

                if (!isPK)
                {
                    col.Indexed();
                }
            }

            if (isNullable)
                col.Nullable();
            else
                col.NotNullable();

            if (isPK)
                col.PrimaryKey();

            return self;
        }

        public static IAlterTableAddColumnOrAlterColumnOrSchemaOrDescriptionSyntax IntForeignKey(this IAlterTableAddColumnOrAlterColumnOrSchemaOrDescriptionSyntax self,
            string name, string foreignTable, bool isNullable, bool isUnique = false, bool onDeleteCascade = false)
        {
            IAlterTableColumnOptionOrAddColumnOrAlterColumnSyntax col;

            var rule = onDeleteCascade ? System.Data.Rule.Cascade : System.Data.Rule.None;

            if (isUnique)
            {
                col = self.AddColumn(name).AsInt32().ForeignKey(foreignTable, "Id").OnDelete(rule).Unique();
            }
            else
            {
                col = self.AddColumn(name).AsInt32().ForeignKey(foreignTable, "Id").OnDelete(rule).Indexed();
            }

            if (isNullable)
                col.Nullable();
            else
                col.NotNullable();

            return self;
        }

        internal class SQLServerFunction
        {
            private string _functionName;

            public SQLServerFunction(string functionName)
            {
                _functionName = functionName;
            }

            public override string ToString()
            {
                return _functionName;
            }
        }
    }
}