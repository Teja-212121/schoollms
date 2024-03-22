import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EInstituteType } from "../Web/Enums.EInstituteType";
import { InstituteRow } from "./InstituteRow";

export interface InstituteColumns {
    Id: Column<InstituteRow>;
    Name: Column<InstituteRow>;
    Description: Column<InstituteRow>;
    EType: Column<InstituteRow>;
    Address: Column<InstituteRow>;
    City: Column<InstituteRow>;
    StateTitle: Column<InstituteRow>;
    DistrictTitle: Column<InstituteRow>;
    TalukaTitle: Column<InstituteRow>;
    LocationInfo: Column<InstituteRow>;
    EstablishmentDate: Column<InstituteRow>;
    PrincipalName: Column<InstituteRow>;
}

export class InstituteColumns extends ColumnsBase<InstituteRow> {
    static readonly columnsKey = 'Institute.Institute';
    static readonly Fields = fieldsProxy<InstituteColumns>();
}

[EInstituteType]; // referenced types