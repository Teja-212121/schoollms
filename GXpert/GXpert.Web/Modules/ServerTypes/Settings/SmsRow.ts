import { fieldsProxy } from "@serenity-is/corelib";

export interface SmsRow {
    Id?: number;
    ApiKey?: string;
    Sender?: string;
    EntityId?: string;
    TemplateId?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class SmsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'ApiKey';
    static readonly localTextPrefix = 'Settings.Sms';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SmsRow>();
}