using FluentMigrator;
using Let3arafo.Migration;

namespace Let3arafo.Data._100
{
    [Migration(8)]
    public class _0008_CreateCommunityUserTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table(Tables.CommunityUser)
                   .AutoId()
                   .IntForeignKey("CommunityId", Tables.Community, false, false)
                   .IntForeignKey("UserId", Tables.User, false, false)
                   .ChangeInfo();
        }

        public override void Down()
        {
            Delete.Table(Tables.CommunityUser);
        }
    }
}