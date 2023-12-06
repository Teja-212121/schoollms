import { fieldsProxy } from "@serenity-is/corelib";

export interface SmtpRow {
    Id?: number;
    Server?: string;
    Port?: number;
    Username?: string;
    Password?: string;
    IsSsl?: boolean;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class SmtpRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Server';
    static readonly localTextPrefix = 'Settings.Smtp';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SmtpRow>();
}