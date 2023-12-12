using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;

    [Migration(20231208181000)]
    public class DefaultDB_20231208_181000_AlterActivationsLog : Migration
    {
        public override void Up()
        {
            
            Alter.Table("Activations")
                .AlterColumn("ActivationLogId").AsInt32().Nullable()
                    ;
        }
        public override void Down()
        {

        }
    }
