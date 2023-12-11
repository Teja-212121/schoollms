import { fieldsProxy } from "@serenity-is/corelib";
import { EPreDefinedKeyStatus } from "../Rio/Web.Enums.EPreDefinedKeyStatus";

export interface PreDefinedKeyRow {
    Id?: number;
    SerialKey?: string;
    EStatus?: EPreDefinedKeyStatus;
    IsActive?: number;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class PreDefinedKeyRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'SerialKey';
    static readonly localTextPrefix = 'Activation.PreDefinedKey';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PreDefinedKeyRow>();
}