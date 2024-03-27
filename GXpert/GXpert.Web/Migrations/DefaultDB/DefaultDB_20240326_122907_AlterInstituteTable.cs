using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

[Migration(20240326_122907)]
public class DefaultDB_20240326_122907_AlterInstituteTable : Migration
{
    public override void Up()
    {


        Alter.Table("Institutes")
             .AlterColumn("Address").AsString(1000).Nullable();
        Alter.Table("Institutes")
          .AlterColumn("City").AsString(200).Nullable();
        Alter.Table("Institutes")
          .AlterColumn("StateId").AsInt32().Nullable();
        Alter.Table("Institutes")
          .AlterColumn("DistrictId").AsInt32().Nullable();
        Alter.Table("Institutes")
          .AlterColumn("TalukaId").AsInt32().Nullable();

        Alter.Table("Branch")
           .AddColumn("BranchCode").AsInt32().Nullable();

        Rename.Table("InstituteClasses").To("InstituteDivision");


        Alter.Table("InstituteDivision")
                .AddColumn("SemesterId").AsInt32().Nullable()
                    .ForeignKey("Semester", "Id");


        Execute.Sql(@"ALTER TABLE [dbo].[InstituteStudents] DROP CONSTRAINT [FK_SchoolStudents_ClassId_Classes_Id];
ALTER TABLE InstituteTimeTable
DROP COLUMN InstituteClassesId;

GO");


        Alter.Table("InstituteStudents")
          .AddColumn("SemesterId").AsInt32().Nullable()
              .ForeignKey("Semester", "Id");
        Alter.Table("InstituteStudents")
            .AddColumn("StartDate").AsDateTime().Nullable();
        Alter.Table("InstituteStudents")
            .AddColumn("EndDate").AsDateTime().Nullable();
        Alter.Table("InstituteStudents")
                     .AlterColumn("ClassId").AsString(500).Nullable();
         Alter.Table("InstituteStudents")
         .AddColumn("InstituteDivisionId").AsInt32().Nullable()
             .ForeignKey("InstituteDivision", "Id");


        Alter.Table("InstituteTeachers")
          .AddColumn("SemesterId").AsInt32().Nullable()
              .ForeignKey("Semester", "Id");
        Alter.Table("InstituteTeachers")
          .AddColumn("InstituteDivisionId").AsInt32().Nullable()
             .ForeignKey("InstituteDivision", "Id");

        Alter.Table("InstituteTimeTable")
          .AddColumn("ClassRoomNo").AsInt32().Nullable();

        Alter.Table("InstituteTimeTable")
           .AddColumn("InstituteDivisionId").AsInt32().Nullable()
               .ForeignKey("InstituteDivision", "Id");

    }
    public override void Down()
    {

    }
}
