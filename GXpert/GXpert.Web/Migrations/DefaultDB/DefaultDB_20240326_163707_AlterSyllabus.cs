using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

    [Migration(20240326_163707)]
    public class DefaultDB_20240326_163707_AlterSyllabus : Migration
    {
        public override void Up()
    {
        Alter.Table("Semester")
          .AddColumn("Description").AsString(2000).Nullable()
          .AddColumn("SortOrder").AsInt16().Nullable();

        Alter.Table("Subjects")
        .AlterColumn("MediumId").AsInt32().Nullable();

         Alter.Table("Topics")
        .AlterColumn("MediumId").AsInt32().Nullable();

        Alter.Table("Subjects")
          .AlterColumn("SortOrder").AsInt16().Nullable()
          .AlterColumn("ClassId").AsInt32().Nullable();

        Alter.Table("Topics")
      .AlterColumn("Weightage").AsFloat().Nullable()
      .AlterColumn("SortOrder").AsInt16().Nullable();
    }
    public override void Down()
        {

        }
    }
