import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface BloomsTaxanomyRow {
    Id?: number;
    CoginitiveSkill?: string;
    SortOrder?: number;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class BloomsTaxanomyRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'CoginitiveSkill';
    static readonly localTextPrefix = 'Masters.BloomsTaxanomy';
    static readonly lookupKey = 'Masters.BloomsTaxanomy';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<BloomsTaxanomyRow>('Masters.BloomsTaxanomy') }
    static async getLookupAsync() { return getLookupAsync<BloomsTaxanomyRow>('Masters.BloomsTaxanomy') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<BloomsTaxanomyRow>();
}