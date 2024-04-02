import { fieldsProxy } from "@serenity-is/corelib";

export interface UserAcademicRow {
    Id?: number;
    StudentId?: number;
    AcademicYearId?: number;
    Title?: string;
    Description?: string;
    IsVerify?: boolean;
    VerifyBy?: number;
    StudentPrn?: string;
    AcademicYearName?: string;
}

export abstract class UserAcademicRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Masters.UserAcademic';
    static readonly deletePermission = 'Masters:MastersManagement:Modify';
    static readonly insertPermission = 'Masters:MastersManagement:Modify';
    static readonly readPermission = 'Masters:MastersManagement:View';
    static readonly updatePermission = 'Masters:MastersManagement:Modify';

    static readonly Fields = fieldsProxy<UserAcademicRow>();
}