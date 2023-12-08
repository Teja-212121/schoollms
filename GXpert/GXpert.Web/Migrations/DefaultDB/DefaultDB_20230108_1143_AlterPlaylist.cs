using FluentMigrator;
using Serenity.Extensions;

namespace GExpert.Migrations.DefaultDB;
[DefaultDB, MigrationKey(202301081143)]
public class DefaultDB_20230108_1143_AlterPlaylist : AutoReversingMigration
{
    public override void Up()
    {
        #region Playlist
        Alter.Table("PlayLists")
            .AddColumn("PlayListFilePath").AsString(int.MaxValue).Nullable()
            .AddColumn("PlayListVersion").AsInt32().Nullable();

        Alter.Table("PlayListContents")
            .AlterColumn("ContentId").AsInt32().Nullable()
            .AlterColumn("ExamId").AsInt32().Nullable()
            .AlterColumn("AssignmentId").AsInt32().Nullable()        
            .AddColumn("eContentType").AsInt16().NotNullable();

        this.CreateTableWithId32("PreDefinedKeys", "Id", s => s
            .WithColumn("SerialKey").AsString(100).NotNullable()
            .WithColumn("eStatus").AsInt16().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));
        #endregion
    }
}