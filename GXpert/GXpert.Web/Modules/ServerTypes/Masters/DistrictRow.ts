import { fieldsProxy } from "@serenity-is/corelib";

export interface DistrictRow {
    Id?: number;
    Title?: string;
    StateId?: number;
    ShortName?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    StateTitle?: string;
}

export abstract class DistrictRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Masters.District';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<DistrictRow>();
}