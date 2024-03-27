import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BranchRow } from "./BranchRow";

export interface BranchColumns {
    Id: Column<BranchRow>;
    Title: Column<BranchRow>;
    InstituteName: Column<BranchRow>;
    DepartmentTitle: Column<BranchRow>;
    Description: Column<BranchRow>;
}

export class BranchColumns extends ColumnsBase<BranchRow> {
    static readonly columnsKey = 'Institute.Branch';
    static readonly Fields = fieldsProxy<BranchColumns>();
}