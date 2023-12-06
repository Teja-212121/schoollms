import { StringEditor, IntegerEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ClassForm {
    Title: StringEditor;
    Description: StringEditor;
    SortOrder: IntegerEditor;
    Weightage: DecimalEditor;
    Thumbnail: StringEditor;
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

            initFormType(ClassForm, [
                'Title', w0,
                'Description', w0,
                'SortOrder', w1,
                'Weightage', w2,
                'Thumbnail', w0
            ]);
        }
    }
}