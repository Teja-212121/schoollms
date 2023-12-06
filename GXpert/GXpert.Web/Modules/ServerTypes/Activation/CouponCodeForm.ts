import { StringEditor, LookupEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CouponCodeForm {
    Code: StringEditor;
    PlayListId: LookupEditor;
    ValidityType: IntegerEditor;
    CountType: IntegerEditor;
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
            var w2 = IntegerEditor;
            var w3 = DateEditor;

            initFormType(CouponCodeForm, [
                'Code', w0,
                'PlayListId', w1,
                'ValidityType', w2,
                'CountType', w2,
                'Count', w2,
                'ValidityInDays', w2,
                'ValidDate', w3,
                'ConsumedCount', w2,
                'CouponValidityDate', w3
            ]);
        }
    }
}