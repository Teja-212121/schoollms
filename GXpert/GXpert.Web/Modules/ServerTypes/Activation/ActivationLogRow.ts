import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EKeyStatus } from "../Web/Enums.EKeyStatus";

export interface ActivationLogRow {
    Id?: number;
    Code?: string;
    SerialKey?: string;
    TeacherId?: number;
    PlayListId?: number;
    DeviceId?: string;
    DeviceDetails?: string;
    EStatus?: EKeyStatus;
    Note?: string;
    IsActive?: number;
    TeacherPrn?: string;
    PlayListTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ActivationLogRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Code';
    static readonly localTextPrefix = 'Activation.ActivationLog';
    static readonly lookupKey = 'Activation.ActivationLog';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ActivationLogRow>('Activation.ActivationLog') }
    static async getLookupAsync() { return getLookupAsync<ActivationLogRow>('Activation.ActivationLog') }

    static readonly deletePermission = 'Activation:ActivationManagement:Modify';
    static readonly insertPermission = 'Activation:ActivationManagement:Modify';
    static readonly readPermission = 'Activation:ActivationManagement:View';
    static readonly updatePermission = 'Activation:ActivationManagement:Modify';

    static readonly Fields = fieldsProxy<ActivationLogRow>();
}