import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { HodRow } from "./HodRow";

export interface HodColumns {
    Id: Column<HodRow>;
    Name: Column<HodRow>;
    Email: Column<HodRow>;
    Mobile: Column<HodRow>;
    Username: Column<HodRow>;
    StateTitle: Column<HodRow>;
    DistrictTitle: Column<HodRow>;
    TalukaTitle: Column<HodRow>;
    Dob: Column<HodRow>;
    InstituteName: Column<HodRow>;
}

export class HodColumns extends ColumnsBase<HodRow> {
    static readonly columnsKey = 'Users.Hod';
    static readonly Fields = fieldsProxy<HodColumns>();
}