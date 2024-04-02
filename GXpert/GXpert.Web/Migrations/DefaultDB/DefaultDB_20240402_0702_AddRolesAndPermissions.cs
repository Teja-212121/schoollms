using FluentMigrator;
using System;

namespace GXpert.Migrations.DefaultDB
{
    [Migration(20240402_0702)]
    public class DefaultDB_20240402_0702_AddRolesAndPermissions : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Roles")
                .Row(new
                {
                    RoleName = "Publisher",
                    RoleKey = "Administration:Publisher"
                });
            Insert.IntoTable("Roles")
                .Row(new
                {
                    RoleName = "Student",
                    RoleKey = "Administration:Student"
                });
            Insert.IntoTable("Roles")
                .Row(new
                {
                    RoleName = "Teacher",
                    RoleKey = "Administration:Teacher"
                });

            Execute.Sql(@"DELETE FROM RolePermissions");

            #region Publisher Role

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Activation:ActivationManagement:Delete"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Activation:ActivationManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Activation:ActivationManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Analytics:AnalyticsManagement:Delete"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Analytics:AnalyticsManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Analytics:AnalyticsManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Attendance:AttendanceManagement:Delete"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Attendance:AttendanceManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Attendance:AttendanceManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Content:ContentManagement:Delete"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Content:ContentManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Content:ContentManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Exams:ExamsManagement:Delete"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Exams:ExamsManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Exams:ExamsManagement:View"
                });
            Insert.IntoTable("RolePermissions")
              .Row(new
              {
                  RoleId = "1",
                  PermissionKey = "Institute:InstituteManagement:Delete"
              });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Institute:InstituteManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Institute:InstituteManagement:View"
                });
            Insert.IntoTable("RolePermissions")
              .Row(new
              {
                  RoleId = "1",
                  PermissionKey = "LiveSessions:LiveSessionsManagement:Delete"
              });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "LiveSessions:LiveSessionsManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "LiveSessions:LiveSessionsManagement:View"
                });
            Insert.IntoTable("RolePermissions")
              .Row(new
              {
                  RoleId = "1",
                  PermissionKey = "Masters:MastersManagement:Delete"
              });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Masters:MastersManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Masters:MastersManagement:View"
                });
            Insert.IntoTable("RolePermissions")
              .Row(new
              {
                  RoleId = "1",
                  PermissionKey = "Playlist:PlaylistManagement:Delete"
              });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Playlist:PlaylistManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Playlist:PlaylistManagement:View"
                });
            Insert.IntoTable("RolePermissions")
              .Row(new
              {
                  RoleId = "1",
                  PermissionKey = "QuestionBank:QuestionBankManagement:Delete"
              });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "QuestionBank:QuestionBankManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "QuestionBank:QuestionBankManagement:View"
                });
            Insert.IntoTable("RolePermissions")
              .Row(new
              {
                  RoleId = "1",
                  PermissionKey = "Syllabus:SyllabusManagement:Delete"
              });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Syllabus:SyllabusManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Syllabus:SyllabusManagement:View"
                });
            Insert.IntoTable("RolePermissions")
              .Row(new
              {
                  RoleId = "1",
                  PermissionKey = "Users:UsersManagement:Delete"
              });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Users:UsersManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Users:UsersManagement:View"
                });
            Insert.IntoTable("RolePermissions")
              .Row(new
              {
                  RoleId = "1",
                  PermissionKey = "Skills:SkillsManagement:Delete"
              });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Skills:SkillsManagement:Modify"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Skills:SkillsManagement:View"
                });

            Insert.IntoTable("RolePermissions")
                .Row(new
                {
                    RoleId = "1",
                    PermissionKey = "Administration:Publisher"
                });
            #endregion

        }
        public override void Down()
        {
        }
    }
}