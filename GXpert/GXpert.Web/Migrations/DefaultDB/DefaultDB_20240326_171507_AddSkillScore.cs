using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

    [Migration(20240326_171507)]
    public class DefaultDB_20240326_171507_AddSkillScore : Migration
    {
        public override void Up()
    {

        Alter.Table("Topics")
      .AlterColumn("Description").AsString(2000).Nullable();

        Alter.Table("UserSkillsScore")
          .AddColumn("Score").AsFloat().Nullable();
        
     
    }
    public override void Down()
        {

        }
    }
