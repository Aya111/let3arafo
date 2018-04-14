using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
using Let3arafo.Migration;

namespace Let3arafo.Data._100
{
    [Migration(6)]
    public class _0006_CreateCommunityCategoryTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table(Tables.CommunityCategory)
                       .AutoId()
                       .WithColumn("Name").AsString(StringLength._1000).NotNullable()
                       .WithColumn("IsActive").AsBoolean().WithDefaultValue(true);
        }
        public override void Down()
        {
            Delete.Table(Tables.CommunityCategory);
        }

    }
}
