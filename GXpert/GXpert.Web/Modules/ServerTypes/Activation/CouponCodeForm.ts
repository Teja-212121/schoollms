import { StringEditor, LookupEditor, EnumEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { ECountType } from "../Web/Enums.ECountType";
import { EValidityType } from "../Web/Enums.EValidityType";

export interface CouponCodeForm {
    Code: StringEditor;
    PlayListId: LookupEditor;
    ValidityType: EnumEditor;
    CountType: EnumEditor;
    Count: IntegerEditor;
    ValidityInDays: IntegerEditor;
    ValidDate: DateEditor;
    ConsumedCount: IntegerEditor;
    CouponValidityDate: DateEditor;
}

export class CouponCodeForm extends PrefixedContext {
    static readonly formKey = 'Activation.CouponCode';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CouponCodeForm.init)  {
            CouponCodeForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = EnumEditor;
            var w3 = IntegerEditor;
            var w4 = DateEditor;

            initFormType(CouponCodeForm, [
                'Code', w0,
                'PlayListId', w1,
                'ValidityType', w2,
                'CountType', w2,
                'Count', w3,
                'ValidityInDays', w3,
                'ValidDate', w4,
                'ConsumedCount', w3,
                'CouponValidityDate', w4
            ]);
        }
    }
}

[EValidityType, ECountType]; // referenced types