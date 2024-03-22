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
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<UserAcademicRow>();
}