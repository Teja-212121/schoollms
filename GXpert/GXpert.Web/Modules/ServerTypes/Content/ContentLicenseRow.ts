import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ContentLicenseRow {
    Id?: number;
    Name?: string;
    Description?: string;
    IsActive?: number;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentLicenseRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Content.ContentLicense';
    static readonly lookupKey = 'Content.ContentLicense';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ContentLicenseRow>('Content.ContentLicense') }
    static async getLookupAsync() { return getLookupAsync<ContentLicenseRow>('Content.ContentLicense') }

    static readonly deletePermission = 'Content:ContentManagement:View';
    static readonly insertPermission = 'Content:ContentManagement:View';
    static readonly readPermission = 'Content:ContentManagement:View';
    static readonly updatePermission = 'Content:ContentManagement:View';

    static readonly Fields = fieldsProxy<ContentLicenseRow>();
}