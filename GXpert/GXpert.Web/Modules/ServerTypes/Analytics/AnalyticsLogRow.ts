import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface AnalyticsLogRow {
    Id?: number;
    ContentId?: number;
    ActivationId?: number;
    StudentId?: number;
    StartDatetime?: string;
    EndDateTime?: string;
    TimeSpent?: number;
    IsActive?: boolean;
    ContentTitle?: string;
    ActivationDeviceId?: string;
    StudentPrn?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class AnalyticsLogRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Analytics.AnalyticsLog';
    static readonly lookupKey = 'Analytics.AnalyticsLog';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<AnalyticsLogRow>('Analytics.AnalyticsLog') }
    static async getLookupAsync() { return getLookupAsync<AnalyticsLogRow>('Analytics.AnalyticsLog') }

    static readonly deletePermission = 'Analytics:AnalyticsManagement:Modify';
    static readonly insertPermission = 'Analytics:AnalyticsManagement:Modify';
    static readonly readPermission = 'Analytics:AnalyticsManagement:View';
    static readonly updatePermission = 'Analytics:AnalyticsManagement:Modify';

    static readonly Fields = fieldsProxy<AnalyticsLogRow>();
}