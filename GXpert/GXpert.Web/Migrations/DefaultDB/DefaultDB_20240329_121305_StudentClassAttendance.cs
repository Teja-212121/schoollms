using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

[Migration(20240329_121305)]
public class DefaultDB_20240329_121305_StudentClassAttendance : Migration
{
    public override void Up()
    {

        this.CreateTableWithId32("StudentClassAttendance", "Id", s => s
            .WithColumn("InstituteTimeTableId").AsInt32().NotNullable()
                .ForeignKey("InstituteTimeTable", "Id")
            .WithColumn("StudentId").AsInt32().NotNullable()
                   .ForeignKey("Students","Id")
            .WithColumn("AttendanceStatus").AsInt16().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

        Alter.Table("InstituteTimeTable")
         .AddColumn("TeacherAttendanceStatus").AsInt16().Nullable();

        Alter.Table("ContentAudio")
           .AlterColumn("LanguageId").AsInt32().Nullable();


        Alter.Table("ContentSubtitles")
           .AlterColumn("LanguageId").AsInt32().Nullable();

        Alter.Table("Assignments")
          .AlterColumn("UpdateDate").AsDateTime().Nullable()
         .AlterColumn("UpdateUserId").AsInt32().Nullable();


    }
    public override void Down()
    {

    }
}
