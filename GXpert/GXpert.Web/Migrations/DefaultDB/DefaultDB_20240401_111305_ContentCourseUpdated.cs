using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

[Migration(20240401_111305)]
public class DefaultDB_20240401_111305_ContentCourseUpdated : Migration
{
    public override void Up()
    {
        Alter.Table("ContentCourse")
          .AddColumn("SubjectId").AsInt32().Nullable()
             .ForeignKey("Subjects", "Id")
          .AddColumn("TopicId").AsInt32().Nullable()
             .ForeignKey("Topics", "Id");

        Alter.Table("QuestionCourse")
         .AddColumn("SubjectId").AsInt32().Nullable()
            .ForeignKey("Subjects", "Id")
         .AddColumn("TopicId").AsInt32().Nullable()
            .ForeignKey("Topics", "Id");
    }
    public override void Down()
    {

    }
}
