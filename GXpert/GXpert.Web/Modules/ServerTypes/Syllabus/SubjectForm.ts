import { StringEditor, TextAreaEditor, IntegerEditor, ServiceLookupEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SubjectForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    SortOrder: IntegerEditor;
    ClassId: ServiceLookupEditor;
    MediumId: ServiceLookupEditor;
    Weightage: DecimalEditor;
    Thumbnail: StringEditor;
}

export class SubjectForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Subject';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SubjectForm.init)  {
            SubjectForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = IntegerEditor;
            var w3 = ServiceLookupEditor;
            var w4 = DecimalEditor;

            initFormType(SubjectForm, [
                'Title', w0,
                'Description', w1,
                'SortOrder', w2,
                'ClassId', w3,
                'MediumId', w3,
                'Weightage', w4,
                'Thumbnail', w0
            ]);
        }
    }
}