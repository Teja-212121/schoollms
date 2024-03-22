import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { UserAcademicRow } from "./UserAcademicRow";

export interface UserAcademicColumns {
    Id: Column<UserAcademicRow>;
    StudentPrn: Column<UserAcademicRow>;
    AcademicYearName: Column<UserAcademicRow>;
    Title: Column<UserAcademicRow>;
    Description: Column<UserAcademicRow>;
    IsVerify: Column<UserAcademicRow>;
    VerifyBy: Column<UserAcademicRow>;
}

export class UserAcademicColumns extends ColumnsBase<UserAcademicRow> {
    static readonly columnsKey = 'Masters.UserAcademic';
    static readonly Fields = fieldsProxy<UserAcademicColumns>();
}