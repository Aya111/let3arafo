using FluentMigrator;
using Let3arafo.Migration;

namespace Let3arafo.Data._100
{
    [Migration(5)]
    public class _0005_CreatePostContentTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table(Tables.PostContent)
                .AutoId()
                .WithColumn("MimeType").AsString(StringLength._50).NotNullable()
                .WithColumn("Path").AsString(StringLength._1000).NotNullable()
                .IntForeignKey("PostId", Tables.PostContent, false, false);
        }

        public override void Down()
        {
            Delete.Table(Tables.PostContent);
        }
    }
}