import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AcademicYearRow } from "./AcademicYearRow";

export interface AcademicYearColumns {
    Id: Column<AcademicYearRow>;
    Name: Column<AcademicYearRow>;
    Description: Column<AcademicYearRow>;
    StartDate: Column<AcademicYearRow>;
    EndDate: Column<AcademicYearRow>;
    InsertDate: Column<AcademicYearRow>;
    InsertUserId: Column<AcademicYearRow>;
    UpdateDate: Column<AcademicYearRow>;
    UpdateUserId: Column<AcademicYearRow>;
    IsActive: Column<AcademicYearRow>;
}

export class AcademicYearColumns extends ColumnsBase<AcademicYearRow> {
    static readonly columnsKey = 'Masters.AcademicYear';
    static readonly Fields = fieldsProxy<AcademicYearColumns>();
}