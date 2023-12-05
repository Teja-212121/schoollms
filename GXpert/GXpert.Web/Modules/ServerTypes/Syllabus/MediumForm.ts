import { StringEditor, DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface MediumForm {
    Title: StringEditor;
    Description: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class MediumForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Medium';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MediumForm.init)  {
            MediumForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;
            var w3 = BooleanEditor;

            initFormType(MediumForm, [
                'Title', w0,
                'Description', w0,
                'InsertDate', w1,
                'InsertUserId', w2,
                'UpdateDate', w1,
                'UpdateUserId', w2,
                'IsActive', w3
            ]);
        }
    }
}