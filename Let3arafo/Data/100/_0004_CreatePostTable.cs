using FluentMigrator;
using Let3arafo.Migration;

namespace Let3arafo.Data._100
{
    [Migration(4)]
    public class _0004_CreatePostTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table(Tables.Post)
                   .AutoId()
                   .WithColumn("Text").AsString(StringLength._30K).NotNullable()
                   .WithColumn("IsActive").AsBoolean().WithDefaultValue(true)
                   .ChangeInfo();
        }

        public override void Down()
        {
            Delete.Table(Tables.Post);
        }
    }
}