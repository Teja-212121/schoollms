import { fieldsProxy } from "@serenity-is/corelib";

export interface ActivationLogRow {
    Id?: number;
    Code?: string;
    SerialKey?: string;
    TeacherId?: number;
    PlayListId?: number;
    DeviceId?: string;
    DeviceDetails?: string;
    EStatus?: number;
    Note?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: number;
    TeacherPrn?: string;
    PlayListTitle?: string;
}

export abstract class ActivationLogRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Code';
    static readonly localTextPrefix = 'Activation.ActivationLog';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ActivationLogRow>();
}