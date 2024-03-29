using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

[Migration(20240329_191305)]
public class DefaultDB_20240329_191305_AlterLiveSessions : Migration
{
    public override void Up()
    {
        Alter.Table("LiveSessions")
          .AddColumn("Title").AsString(1000).NotNullable()
         ;
    }
    public override void Down()
    {

    }
}
