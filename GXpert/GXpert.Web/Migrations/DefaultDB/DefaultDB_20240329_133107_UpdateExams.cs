using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

[Migration(20240329_133107)]
public class DefaultDB_20240329_133107_UpdateExams : Migration
{
    public override void Up()
    {
        Alter.Table("ExamQuestions")
      .AddColumn("CourseId").AsInt32().Nullable()
                .ForeignKey("Course", "Id")
      .AlterColumn("ClassId").AsInt32().Nullable()
      .AddColumn("SemesterId").AsInt32().Nullable()
               .ForeignKey("Semester", "Id")
      .AlterColumn("SubjectId").AsInt32().Nullable();


        Alter.Table("ExamSections")
        .AddColumn("CourseId").AsInt32().Nullable()
             .ForeignKey("Course", "Id")
       .AddColumn("ClassId").AsInt32().Nullable()
             .ForeignKey("Classes", "Id")
       .AddColumn("SemesterId").AsInt32().Nullable()
            .ForeignKey("Semester", "Id")
      .AddColumn("SubjectId").AsInt32().Nullable()
             .ForeignKey("Subjects", "Id")
             .AddColumn("TopicId").AsInt32().Nullable()
                .ForeignKey("Topics", "Id");

    }
    public override void Down()
    {

    }
}
