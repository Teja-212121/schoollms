import { fieldsProxy } from "@serenity-is/corelib";

export interface ActivationRow {
    Id?: number;
    PlayListId?: number;
    TeacherId?: number;
    ActivationLogId?: number;
    DeviceId?: string;
    DeviceDetails?: string;
    ActivationDate?: string;
    ExpiryDate?: string;
    EStatus?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: number;
    PlayListTitle?: string;
    TeacherPrn?: string;
    ActivationLogCode?: string;
}

export abstract class ActivationRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'DeviceId';
    static readonly localTextPrefix = 'Activation.Activation';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ActivationRow>();
}