using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

[Migration(20240327_145407)]
public class DefaultDB_20240327_145407_AlterTeacher : Migration
{
    public override void Up()
    {
        Execute.Sql(@"ALTER TABLE Teachers
            DROP CONSTRAINT FK_Teachers_SchoolId_Schools_Id;
           ALTER TABLE Teachers
           DROP COLUMN SchoolId;
    
");
        Alter.Table("Teachers")
         .AddColumn("InstituteId").AsInt32().Nullable()
             .ForeignKey("Institutes", "Id");

        






    }
    public override void Down()
    {

    }
}
