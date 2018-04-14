using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
using Let3arafo.Migration;

namespace Let3arafo.Data._100
{
    [Migration(1)]
    public class _0001_CreatePersonTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table(Tables.Person)
                .AutoId()
                .WithColumn("FirstName").AsString(StringLength._50).NotNullable()
                .WithColumn("RestOfName").AsString(StringLength._100).NotNullable()
                .WithColumn("BirthDate").AsDate().NotNullable()
                .WithColumn("Gender").AsInt16().NotNullable()
                .WithColumn("NationalId").AsInt64().NotNullable()
                .WithColumn("IdScanPath").AsString(StringLength._1000).NotNullable();
        }
        public override void Down()
        {
            Delete.Table(Tables.Person);
        }

    }
}
