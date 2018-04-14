using FluentMigrator;
using Let3arafo.Migration;

namespace Let3arafo.Data._100
{
    [Migration(3)]
    public class _0003_CreateUserTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table(Tables.User)
                   .AutoId()
                   .IntForeignKey("PersonId", Tables.Person, true, false)
                   .IntForeignKey("CompanyId", Tables.Company, true, false)
                   .WithColumn("UserName").AsString(StringLength._100).NotNullable()
                   .WithColumn("Password").AsString(StringLength._1000).NotNullable()
                   .WithColumn("IsConfirmed").AsBoolean().NotNullable()
                   .WithColumn("IsActive").AsBoolean().WithDefaultValue(true);
        }

        public override void Down()
        {
            Delete.Table(Tables.User);
        }
    }
}