﻿import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface MediumRow {
    Id?: number;
    Title?: string;
    Description?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
}

export abstract class MediumRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Syllabus.Medium';
    static readonly lookupKey = 'Syllabus.Medium';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<MediumRow>('Syllabus.Medium') }
    static async getLookupAsync() { return getLookupAsync<MediumRow>('Syllabus.Medium') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MediumRow>();
}