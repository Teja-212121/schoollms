import { fieldsProxy } from "@serenity-is/corelib";

export interface CouponCodeRow {
    Id?: number;
    Code?: string;
    PlayListId?: number;
    ValidityType?: number;
    CountType?: number;
    Count?: number;
    ValidityInDays?: number;
    ValidDate?: string;
    ConsumedCount?: number;
    CouponValidityDate?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: number;
    PlayListTitle?: string;
}

export abstract class CouponCodeRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Code';
    static readonly localTextPrefix = 'Activation.CouponCode';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<CouponCodeRow>();
}