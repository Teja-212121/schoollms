import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EKeyStatus } from "../Web/Enums.EKeyStatus";
import { EValidityType } from "../Web/Enums.EValidityType";

export interface SerialKeyRow {
    Id?: number;
    SerialKey?: string;
    PlayListId?: number;
    ValidityType?: EValidityType;
    ValidityInDays?: number;
    ValidDate?: string;
    Note?: string;
    EStatus?: EKeyStatus;
    IsActive?: number;
    PlayListTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class SerialKeyRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'SerialKey';
    static readonly localTextPrefix = 'Activation.SerialKey';
    static readonly lookupKey = 'Activation.SerialKey';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<SerialKeyRow>('Activation.SerialKey') }
    static async getLookupAsync() { return getLookupAsync<SerialKeyRow>('Activation.SerialKey') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SerialKeyRow>();
}