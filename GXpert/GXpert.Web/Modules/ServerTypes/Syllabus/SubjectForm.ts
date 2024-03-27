import { ServiceLookupEditor, StringEditor, IntegerEditor, DecimalEditor, ImageUploadEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SubjectForm {
    CourseId: ServiceLookupEditor;
    ClassId: ServiceLookupEditor;
    SemesterId: ServiceLookupEditor;
    Title: StringEditor;
    SortOrder: IntegerEditor;
    Weightage: DecimalEditor;
    Thumbnail: ImageUploadEditor;
    Description: TextAreaEditor;
}

export class SubjectForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Subject';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SubjectForm.init)  {
            SubjectForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = IntegerEditor;
            var w3 = DecimalEditor;
            var w4 = ImageUploadEditor;
            var w5 = TextAreaEditor;

            initFormType(SubjectForm, [
                'CourseId', w0,
                'ClassId', w0,
                'SemesterId', w0,
                'Title', w1,
                'SortOrder', w2,
                'Weightage', w3,
                'Thumbnail', w4,
                'Description', w5
            ]);
        }
    }
}