import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PrincipalRow } from "./PrincipalRow";

export interface PrincipalColumns {
    Id: Column<PrincipalRow>;
    Name: Column<PrincipalRow>;
    Email: Column<PrincipalRow>;
    Mobile: Column<PrincipalRow>;
    Username: Column<PrincipalRow>;
    StateTitle: Column<PrincipalRow>;
    DistrictTitle: Column<PrincipalRow>;
    TalukaTitle: Column<PrincipalRow>;
    Dob: Column<PrincipalRow>;
    InstituteName: Column<PrincipalRow>;
}

export class PrincipalColumns extends ColumnsBase<PrincipalRow> {
    static readonly columnsKey = 'Users.Principal';
    static readonly Fields = fieldsProxy<PrincipalColumns>();
}