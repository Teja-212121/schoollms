import { fieldsProxy } from "@serenity-is/corelib";

export interface BloomsTaxanomyRow {
    Id?: number;
    CoginitiveSkill?: string;
    SortOrder?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
}

export abstract class BloomsTaxanomyRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'CoginitiveSkill';
    static readonly localTextPrefix = 'Masters.BloomsTaxanomy';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<BloomsTaxanomyRow>();
}