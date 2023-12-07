import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { ESchoolType } from "../Web/Enums.ESchoolType";

export interface SchoolRow {
    Id?: number;
    Name?: string;
    Description?: string;
    EType?: ESchoolType;
    Address?: string;
    City?: string;
    StateId?: number;
    DistrictId?: number;
    TalukaId?: number;
    LocationInfo?: string;
    EstablishmentDate?: string;
    IsActive?: boolean;
    StateTitle?: string;
    DistrictTitle?: string;
    TalukaTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class SchoolRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Schools.School';
    static readonly lookupKey = 'Schools.School';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<SchoolRow>('Schools.School') }
    static async getLookupAsync() { return getLookupAsync<SchoolRow>('Schools.School') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SchoolRow>();
}