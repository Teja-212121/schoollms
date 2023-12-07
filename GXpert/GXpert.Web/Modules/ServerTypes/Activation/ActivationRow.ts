import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EKeyStatus } from "../Web/Enums.EKeyStatus";

export interface ActivationRow {
    Id?: number;
    PlayListId?: number;
    TeacherId?: number;
    ActivationLogId?: number;
    DeviceId?: string;
    DeviceDetails?: string;
    ActivationDate?: string;
    ExpiryDate?: string;
    EStatus?: EKeyStatus;
    IsActive?: number;
    PlayListTitle?: string;
    TeacherPrn?: string;
    ActivationLogCode?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ActivationRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'DeviceId';
    static readonly localTextPrefix = 'Activation.Activation';
    static readonly lookupKey = 'Activation.Activation';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ActivationRow>('Activation.Activation') }
    static async getLookupAsync() { return getLookupAsync<ActivationRow>('Activation.Activation') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ActivationRow>();
}