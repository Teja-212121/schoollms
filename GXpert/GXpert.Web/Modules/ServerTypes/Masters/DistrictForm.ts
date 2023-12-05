import { StringEditor, ServiceLookupEditor, DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DistrictForm {
    Title: StringEditor;
    StateId: ServiceLookupEditor;
    ShortName: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class DistrictForm extends PrefixedContext {
    static readonly formKey = 'Masters.District';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DistrictForm.init)  {
            DistrictForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = DateEditor;
            var w3 = IntegerEditor;
            var w4 = BooleanEditor;

            initFormType(DistrictForm, [
                'Title', w0,
                'StateId', w1,
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