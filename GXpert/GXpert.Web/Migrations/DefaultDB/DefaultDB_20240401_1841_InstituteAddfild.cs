using FluentMigrator;

namespace GXpert.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20240401_1841)]
public class DefaultDB_20240401_1841_InstituteAddfild : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("InstituteTimeTable")
            .AddColumn("DepartmentId").AsInt32().Nullable()
                     .ForeignKey("Departments", "Id")
            .AddColumn("InstituteId").AsInt32().Nullable()
               .ForeignKey("Institutes", "Id")
          .AddColumn("BranchId").AsInt32().Nullable()
               .ForeignKey("Branch", "Id");
              
            }
}