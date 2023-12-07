import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ModuleRow } from "./ModuleRow";

export interface ModuleColumns {
    Id: Column<ModuleRow>;
    Title: Column<ModuleRow>;
    Description: Column<ModuleRow>;
    ParentTitle: Column<ModuleRow>;
    SortOrder: Column<ModuleRow>;
    InsertDate: Column<ModuleRow>;
    InsertUserId: Column<ModuleRow>;
    UpdateDate: Column<ModuleRow>;
    UpdateUserId: Column<ModuleRow>;
    IsActive: Column<ModuleRow>;
}

export class ModuleColumns extends ColumnsBase<ModuleRow> {
    static readonly columnsKey = 'Playlist.Module';
    static readonly Fields = fieldsProxy<ModuleColumns>();
}