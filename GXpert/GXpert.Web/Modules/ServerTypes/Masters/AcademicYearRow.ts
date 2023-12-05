import { fieldsProxy } from "@serenity-is/corelib";

export interface AcademicYearRow {
    Id?: number;
    Name?: string;
    Description?: string;
    StartDate?: string;
    EndDate?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
}

export abstract class AcademicYearRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Masters.AcademicYear';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AcademicYearRow>();
}