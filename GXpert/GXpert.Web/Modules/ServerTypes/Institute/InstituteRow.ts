import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EInstituteType } from "../Web/Enums.EInstituteType";

export interface InstituteRow {
    Id?: number;
    Name?: string;
    Description?: string;
    EType?: EInstituteType;
    Address?: string;
    City?: string;
    StateId?: number;
    DistrictId?: number;
    TalukaId?: number;
    LocationInfo?: string;
    EstablishmentDate?: string;
    IsActive?: boolean;
    PrincipalId?: number;
    StateTitle?: string;
    DistrictTitle?: string;
    TalukaTitle?: string;
    PrincipalName?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class InstituteRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Institute.Institute';
    static readonly lookupKey = 'Institute.Institute';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<InstituteRow>('Institute.Institute') }
    static async getLookupAsync() { return getLookupAsync<InstituteRow>('Institute.Institute') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<InstituteRow>();
}