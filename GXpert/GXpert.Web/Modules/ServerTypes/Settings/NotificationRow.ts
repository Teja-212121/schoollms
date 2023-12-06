import { fieldsProxy } from "@serenity-is/corelib";

export interface NotificationRow {
    Id?: number;
    NotificationGuid?: string;
    Message?: string;
    Title?: string;
    CreatedOnUtc?: string;
    SentTries?: number;
    SentOnUtc?: string;
    HasError?: boolean;
    Result?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class NotificationRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Message';
    static readonly localTextPrefix = 'Settings.Notification';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<NotificationRow>();
}