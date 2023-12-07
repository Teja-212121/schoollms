import { StringEditor, ServiceLookupEditor, DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TalukaForm {
    Title: StringEditor;
    StateId: ServiceLookupEditor;
    DistrictId: ServiceLookupEditor;
    ShortName: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class TalukaForm extends PrefixedContext {
    static readonly formKey = 'Masters.Taluka';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TalukaForm.init)  {
            TalukaForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = DateEditor;
            var w3 = IntegerEditor;
            var w4 = BooleanEditor;

            initFormType(TalukaForm, [
                'Title', w0,
                'StateId', w1,
                'DistrictId', w1,
                'ShortName', w0,
                'InsertDate', w2,
                'InsertUserId', w3,
                'UpdateDate', w2,
                'UpdateUserId', w3,
                'IsActive', w4
            ]);
        }
    }
}