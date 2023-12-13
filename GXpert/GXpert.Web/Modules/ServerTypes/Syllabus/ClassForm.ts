import { StringEditor, TextAreaEditor, IntegerEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ClassForm {
    Title: StringEditor;
    Description: TextAreaEditor;
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
            var w1 = TextAreaEditor;
            var w2 = IntegerEditor;
            var w3 = DecimalEditor;

            initFormType(ClassForm, [
                'Title', w0,
                'Description', w1,
                'SortOrder', w2,
                'Weightage', w3,
                'Thumbnail', w0
            ]);
        }
    }
}