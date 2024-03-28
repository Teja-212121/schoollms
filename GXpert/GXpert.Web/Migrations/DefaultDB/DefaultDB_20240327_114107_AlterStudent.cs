using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

    [Migration(20240327_114107)]
    public class DefaultDB_20240327_114107_AlterStudent : Migration
    {
    public override void Up()
    {

        Alter.Table("Students")
      .AddColumn("CurrentAcademicYearId").AsInt32().Nullable()
                .ForeignKey("AcademicYears", "Id")
      .AddColumn("InstituteId").AsInt32().Nullable().
         ForeignKey("Institutes", "Id")
      .AddColumn("DepartmentId").AsInt32().Nullable()
                .ForeignKey("Departments", "Id")
      .AddColumn("BranchId").AsInt32().Nullable()
                .ForeignKey("Branch", "Id")
      .AddColumn("CourseId").AsInt32().Nullable()
                .ForeignKey("Course", "Id")
      .AddColumn("ClassId").AsInt32().Nullable()
                .ForeignKey("Classes", "Id")
      .AddColumn("SemesterId").AsInt32().Nullable()
               .ForeignKey("Semester", "Id")
      .AddColumn("DivisionId").AsInt32().Nullable()
               .ForeignKey("InstituteDivision", "Id")
      .AddColumn("Gender").AsInt16().NotNullable()
      .AddColumn("AddressLine1").AsString(1000).NotNullable()
      .AddColumn("AddressLine2").AsString(1000).Nullable()
                ;

        Alter.Table("AcademicPerformance")
     .AddColumn("AttemptDate").AsDateTime().Nullable();

        Alter.Table("AcademicSubjectPerformance")
      .AddColumn("AttemptDate").AsDateTime().Nullable();

        Execute.Sql(@"ALTER TABLE Students
            DROP CONSTRAINT FK_Students_SchoolId_Schools_Id;


           ALTER TABLE Students
           DROP COLUMN SchoolId;

");
    }
    public override void Down()
    {

    }
}
