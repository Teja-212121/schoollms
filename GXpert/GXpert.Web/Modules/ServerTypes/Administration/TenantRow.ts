import { fieldsProxy } from "@serenity-is/corelib";

export interface TenantRow {
    TenantId?: number;
    TenantName?: string;
    OwnerId?: number;
}

export abstract class TenantRow {
    static readonly idProperty = 'TenantId';
    static readonly nameProperty = 'TenantName';
    static readonly localTextPrefix = 'Administration.Tenant';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TenantRow>();
}