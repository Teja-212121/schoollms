import { fieldsProxy } from "@serenity-is/corelib";

export interface TalukaRow {
    Id?: number;
    Title?: string;
    StateId?: number;
    DistrictId?: number;
    ShortName?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    StateTitle?: string;
    DistrictTitle?: string;
}

export abstract class TalukaRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Masters.Taluka';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TalukaRow>();
}