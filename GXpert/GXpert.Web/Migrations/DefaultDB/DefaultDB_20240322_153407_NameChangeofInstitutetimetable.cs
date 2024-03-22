using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

    [Migration(20240322_153407)]
    public class DefaultDB_20240322_153407_NameChangeofInstitutetimetable : Migration
    {
        public override void Up()
        {

        Rename.Table("SchoolTimeTable").To("InstituteTimeTable");

    }
    public override void Down()
        {

        }
    }
