import { StringEditor, DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CommonDataForm {
    CommonDataTitle: StringEditor;
    CommonData: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class CommonDataForm extends PrefixedContext {
    static readonly formKey = 'QuestionBank.CommonData';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CommonDataForm.init)  {
            CommonDataForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;
            var w3 = BooleanEditor;

            initFormType(CommonDataForm, [
                'CommonDataTitle', w0,
                'CommonData', w0,
                'InsertDate', w1,
                'InsertUserId', w2,
                'UpdateDate', w1,
                'UpdateUserId', w2,
                'IsActive', w3
            ]);
        }
    }
}