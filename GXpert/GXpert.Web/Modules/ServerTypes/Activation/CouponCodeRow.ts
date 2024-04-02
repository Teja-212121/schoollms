import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { ECountType } from "../Web/Enums.ECountType";
import { EValidityType } from "../Web/Enums.EValidityType";

export interface CouponCodeRow {
    Id?: number;
    Code?: string;
    PlayListId?: number;
    ValidityType?: EValidityType;
    CountType?: ECountType;
    Count?: number;
    ValidityInDays?: number;
    ValidDate?: string;
    ConsumedCount?: number;
    CouponValidityDate?: string;
    IsActive?: number;
    PlayListTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class CouponCodeRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Code';
    static readonly localTextPrefix = 'Activation.CouponCode';
    static readonly lookupKey = 'Activation.CouponCode';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CouponCodeRow>('Activation.CouponCode') }
    static async getLookupAsync() { return getLookupAsync<CouponCodeRow>('Activation.CouponCode') }

    static readonly deletePermission = 'Activation:ActivationManagement:Modify';
    static readonly insertPermission = 'Activation:ActivationManagement:Modify';
    static readonly readPermission = 'Activation:ActivationManagement:View';
    static readonly updatePermission = 'Activation:ActivationManagement:Modify';

    static readonly Fields = fieldsProxy<CouponCodeRow>();
}