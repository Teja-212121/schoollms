import { fieldsProxy } from "@serenity-is/corelib";

export interface AnalyticsLogRow {
    Id?: number;
    ContentId?: number;
    ActivationId?: number;
    StudentId?: number;
    StartDatetime?: string;
    EndDateTime?: string;
    TimeSpent?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    ContentTitle?: string;
    ActivationDeviceId?: string;
    StudentPrn?: string;
}

export abstract class AnalyticsLogRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Analytics.AnalyticsLog';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AnalyticsLogRow>();
}