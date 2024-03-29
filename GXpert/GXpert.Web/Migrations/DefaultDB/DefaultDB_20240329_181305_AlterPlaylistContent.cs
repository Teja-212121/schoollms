using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

[Migration(20240329_181305)]
public class DefaultDB_20240329_181305_AlterPlaylistContent : Migration
{
    public override void Up()
    {
        Execute.Sql(@"  
            ALTER TABLE PlayListContents
            DROP CONSTRAINT FK_PlayListContents_ExamId_Exams_Id; 
           ALTER TABLE PlayListContents
            DROP CONSTRAINT FK_PlayListContents_LiveSessionId_LiveSessions_Id; 
           ALTER TABLE PlayListContents
            DROP CONSTRAINT FK_PlayListContents_AssignmentId_Assignments_Id; 
           ALTER TABLE PlayListContents
            DROP CONSTRAINT FK_PlayListContents_ContentId_Contents_Id; 
            ALTER TABLE PlayListContents
            DROP CONSTRAINT FK_PlayListContents_ModuleId_Modules_Id;
           ALTER TABLE PlayListContents
            DROP CONSTRAINT FK_PlayListContents_PlayListId_PlayLists_Id;
");

        Alter.Table("PlayListContents")
          .AlterColumn("ExamId").AsInt32().Nullable()
         .AlterColumn("LiveSessionId").AsInt32().Nullable();
    }
    public override void Down()
    {

    }
}
