using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
using Let3arafo.Migration;

namespace Let3arafo.Data._100
{
    [Migration(7)]
    public class _0007_CreateCommunityTable : FluentMigrator.Migration
    {

        public override void Up()
        {
            Create.Table(Tables.Community)
                   .AutoId()
                   .WithColumn("CommunityName").AsString(StringLength._100).NotNullable()
                   .IntForeignKey("CategoryId", Tables.CommunityCategory, false, false)
                   .IntForeignKey("ManagerId", Tables.User, false, false)
                   .WithColumn("IsAgreed").AsBoolean().WithDefaultValue(false)
                   .WithColumn("IsActive").AsBoolean().WithDefaultValue(false)
                   .ChangeInfo();
        }
        public override void Down()
        {
            Delete.Table(Tables.Community);
        }
    }
}
