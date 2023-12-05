import { StringEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CouponCodeForm {
    Code: StringEditor;
    PlayListId: IntegerEditor;
    ValidityType: IntegerEditor;
    CountType: IntegerEditor;
    Count: IntegerEditor;
    ValidityInDays: IntegerEditor;
    ValidDate: DateEditor;
    ConsumedCount: IntegerEditor;
    CouponValidityDate: DateEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
}

export class CouponCodeForm extends PrefixedContext {
    static readonly formKey = 'Activation.CouponCode';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CouponCodeForm.init)  {
            CouponCodeForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;

            initFormType(CouponCodeForm, [
                'Code', w0,
                'PlayListId', w1,
                'ValidityType', w1,
                'CountType', w1,
                'Count', w1,
                'ValidityInDays', w1,
                'ValidDate', w2,
                'ConsumedCount', w1,
                'CouponValidityDate', w2,
                'InsertDate', w2,
                'InsertUserId', w1,
                'UpdateDate', w2,
                'UpdateUserId', w1,
                'IsActive', w1
            ]);
        }
    }
}