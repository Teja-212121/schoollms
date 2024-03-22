import { fieldsProxy } from "@serenity-is/corelib";

export interface InstituteRow {
    Id?: number;
    Name?: string;
    Description?: string;
    EType?: number;
    Address?: string;
    City?: string;
    StateId?: number;
    DistrictId?: number;
    TalukaId?: number;
    LocationInfo?: string;
    EstablishmentDate?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    PrincipalId?: number;
    StateTitle?: string;
    DistrictTitle?: string;
    TalukaTitle?: string;
    PrincipalName?: string;
}

export abstract class InstituteRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Institute.Institute';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<InstituteRow>();
}