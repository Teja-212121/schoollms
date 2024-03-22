using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

[Migration(20240322_173830)]
public class DefaultDB_20240322_173830_MasterTables : Migration
{
    public override void Up()
    {
        this.CreateTableWithId32("PreAcademics", "Id", s => s
        .WithColumn("ExamName").AsString(500).NotNullable()
        .WithColumn("Description").AsString(2000).Nullable()
        .WithColumn("Thumbnail").AsString(500).Nullable()
        .WithColumn("InsertDate").AsDateTime().NotNullable()
        .WithColumn("InsertUserId").AsInt32().NotNullable()
        .WithColumn("UpdateDate").AsDateTime().Nullable()
        .WithColumn("UpdateUserId").AsInt32().Nullable()
        .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));


        this.CreateTableWithId32("PreAcademicsScore", "Id", s => s
       .WithColumn("PreAcadamicsId").AsInt32().NotNullable()
                  .ForeignKey("PreAcademics", "Id")
       .WithColumn("PassedOutDate").AsDateTime().Nullable()
       .WithColumn("MarksObtained").AsFloat().Nullable()
       .WithColumn("OutOfMarks").AsFloat().Nullable()
       .WithColumn("StudentId").AsInt32().Nullable()
                  .ForeignKey("Students", "Id")
       .WithColumn("Remarks").AsString(500).Nullable()
       .WithColumn("InsertDate").AsDateTime().NotNullable()
       .WithColumn("InsertUserId").AsInt32().NotNullable()
       .WithColumn("UpdateDate").AsDateTime().Nullable()
       .WithColumn("UpdateUserId").AsInt32().Nullable()
       .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

        this.CreateTableWithId32("AcademicPerformance", "Id", s => s
           .WithColumn("StudentId").AsInt32().Nullable()
                .ForeignKey("Students", "Id")
           .WithColumn("CourseId").AsInt32().NotNullable()
                .ForeignKey("Course", "Id")
           .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
           .WithColumn("SemesterId").AsInt32().NotNullable()
               .ForeignKey("Semester", "Id")
           .WithColumn("MarksObtained").AsFloat().Nullable()
           .WithColumn("OutOfMarks").AsFloat().Nullable()
           .WithColumn("Remarks").AsString(500).Nullable()
             .WithColumn("AcademicYearId").AsInt32().NotNullable()
                .ForeignKey("AcademicYears", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));



        this.CreateTableWithId32("AcademicSubjectPerformance", "Id", s => s
           .WithColumn("StudentId").AsInt32().Nullable()
                .ForeignKey("Students", "Id")
           .WithColumn("CourseId").AsInt32().NotNullable()
                .ForeignKey("Course", "Id")
           .WithColumn("ClassId").AsInt32().NotNullable()
                .ForeignKey("Classes", "Id")
           .WithColumn("SemesterId").AsInt32().NotNullable()
               .ForeignKey("Semester", "Id")
           .WithColumn("SubjectId").AsInt32().Nullable()
                .ForeignKey("Subjects", "Id")
           .WithColumn("eTypeOfExam").AsInt16().Nullable()
           .WithColumn("MarksObtained").AsFloat().Nullable()
           .WithColumn("OutOfMarks").AsFloat().Nullable()
           .WithColumn("Remarks").AsString(500).Nullable()
           .WithColumn("AcademicYearId").AsInt32().NotNullable()
                .ForeignKey("AcademicYears", "Id")
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));


        this.CreateTableWithId32("Projects", "Id", s => s
          .WithColumn("StudentId").AsInt32().Nullable()
               .ForeignKey("Students", "Id")
          .WithColumn("CourseId").AsInt32().NotNullable()
               .ForeignKey("Course", "Id")
          .WithColumn("ClassId").AsInt32().NotNullable()
               .ForeignKey("Classes", "Id")
          .WithColumn("SemesterId").AsInt32().NotNullable()
              .ForeignKey("Semester", "Id")
           .WithColumn("Title").AsString(500).NotNullable()
           .WithColumn("Description").AsString(2000).Nullable()
          .WithColumn("eType").AsInt16().Nullable()
          );


        this.CreateTableWithId32("ProjectSkills", "Id", s => s
         .WithColumn("SkillCategoryId").AsInt32().Nullable()
               .ForeignKey("SkillCategory", "Id")
         .WithColumn("SkillId").AsInt32().Nullable()
               .ForeignKey("Skills", "Id")
          .WithColumn("ProjectId").AsInt32().Nullable()
               .ForeignKey("Projects", "Id"));

        this.CreateTableWithId32("UserSkillsScore", "Id", s => s
       .WithColumn("SkillCategoryId").AsInt32().Nullable()
             .ForeignKey("SkillCategory", "Id")
       .WithColumn("SkillId").AsInt32().Nullable()
             .ForeignKey("Skills", "Id")
        /*.WithColumn("Score").AsInt32().Nullable()*/);


        this.CreateTableWithId32("UserAcademics", "Id", s => s
      .WithColumn("StudentId").AsInt32().Nullable()
               .ForeignKey("Students", "Id")
      .WithColumn("AcademicYearId").AsInt32().NotNullable()
                .ForeignKey("AcademicYears", "Id")
      .WithColumn("Title").AsString(500).NotNullable()
      .WithColumn("Description").AsString(2000).Nullable()
      .WithColumn("IsVerify").AsBoolean().Nullable()
      .WithColumn("VerifyBy").AsInt32().Nullable()
      );

        Alter.Table("Students")
      .AddColumn("Details").AsInt16().Nullable();

        Alter.Table("AcademicYears")
      .AddColumn("IsCurrent").AsBoolean().Nullable();


    }
    public override void Down()
    {

    }
}
