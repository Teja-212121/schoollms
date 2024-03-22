using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

    [Migration(20240322_175107)]
    public class DefaultDB_20240322_175107_AlterInstitude : Migration
    {
        public override void Up()
        {

        Execute.Sql(@"ALTER TABLE InstituteTeachers
DROP CONSTRAINT FK_SchoolTeachers_SchoolId_Schools_Id;


ALTER TABLE InstituteTeachers
DROP COLUMN SchoolId;

ALTER TABLE InstituteStudents
DROP CONSTRAINT FK_SchoolStudents_SchoolId_Schools_Id;


ALTER TABLE InstituteStudents
DROP COLUMN SchoolId;

ALTER TABLE InstituteTimeTable
DROP CONSTRAINT FK_SchoolTimeTable_SchoolClassId_SchoolClasses_Id;


ALTER TABLE InstituteTimeTable
DROP COLUMN SchoolClassId;
");
       

        Alter.Table("InstituteTeachers")
         .AddColumn("InstituteId").AsInt32().Nullable().
         ForeignKey("Institutes", "Id");

        Alter.Table("InstituteStudents")
            .AddColumn("InstituteId").AsInt32().Nullable().
              ForeignKey("Institutes", "Id");

        Alter.Table("InstituteTimeTable")
        .AddColumn("InstituteClassesId").AsInt32().Nullable();

    }
    public override void Down()
        {

        }
    }
