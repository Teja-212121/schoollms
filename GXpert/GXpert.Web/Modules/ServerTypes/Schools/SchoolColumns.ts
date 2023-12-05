import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SchoolRow } from "./SchoolRow";

export interface SchoolColumns {
    Id: Column<SchoolRow>;
    Name: Column<SchoolRow>;
    Description: Column<SchoolRow>;
    EType: Column<SchoolRow>;
    Address: Column<SchoolRow>;
    City: Column<SchoolRow>;
    StateTitle: Column<SchoolRow>;
    DistrictTitle: Column<SchoolRow>;
    TalukaTitle: Column<SchoolRow>;
    LocationInfo: Column<SchoolRow>;
    EstablishmentDate: Column<SchoolRow>;
    InsertDate: Column<SchoolRow>;
    InsertUserId: Column<SchoolRow>;
    UpdateDate: Column<SchoolRow>;
    UpdateUserId: Column<SchoolRow>;
    IsActive: Column<SchoolRow>;
}

export class SchoolColumns extends ColumnsBase<SchoolRow> {
    static readonly columnsKey = 'Schools.School';
    static readonly Fields = fieldsProxy<SchoolColumns>();
}