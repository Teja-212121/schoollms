import { fieldsProxy } from "@serenity-is/corelib";

export interface SerialKeyRow {
    Id?: number;
    SerialKey?: string;
    PlayListId?: number;
    ValidityType?: number;
    ValidityInDays?: number;
    ValidDate?: string;
    Note?: string;
    EStatus?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: number;
    PlayListTitle?: string;
}

export abstract class SerialKeyRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'SerialKey';
    static readonly localTextPrefix = 'Activation.SerialKey';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SerialKeyRow>();
}