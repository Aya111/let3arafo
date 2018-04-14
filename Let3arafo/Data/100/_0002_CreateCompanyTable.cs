using FluentMigrator;
using Let3arafo.Migration;

namespace Let3arafo.Data._100
{
    [Migration(2)]
    public class _0002_CreateCompanyTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table(Tables.Company)
                    .AutoId()
                    .WithColumn("Name").AsString(StringLength._100).NotNullable();
        }

        public override void Down()
        {
            Delete.Table(Tables.Company);
        }
    }
}