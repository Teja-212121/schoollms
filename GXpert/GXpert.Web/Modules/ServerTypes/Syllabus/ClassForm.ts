import { StringEditor, IntegerEditor, DecimalEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ClassForm {
    Title: StringEditor;
    Description: StringEditor;
    SortOrder: IntegerEditor;
    Weightage: DecimalEditor;
    Thumbnail: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class ClassForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Class';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ClassForm.init)  {
            ClassForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DecimalEditor;
            var w3 = DateEditor;
            var w4 = BooleanEditor;

            initFormType(ClassForm, [
                'Title', w0,
                'Description', w0,
                'SortOrder', w1,
                'Weightage', w2,
                'Thumbnail', w0,
                'InsertDate', w3,
                'InsertUserId', w1,
                'UpdateDate', w3,
                'UpdateUserId', w1,
                'IsActive', w4
            ]);
        }
    }
}