import { ServiceLookupEditor, StringEditor, TextAreaEditor, IntegerEditor, DecimalEditor, ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SubjectForm {
    CourseId: ServiceLookupEditor;
    Title: StringEditor;
    Description: TextAreaEditor;
    SortOrder: IntegerEditor;
    ClassId: ServiceLookupEditor;
    SemesterId: ServiceLookupEditor;
    Weightage: DecimalEditor;
    Thumbnail: ImageUploadEditor;
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
            var w2 = TextAreaEditor;
            var w3 = IntegerEditor;
            var w4 = DecimalEditor;
            var w5 = ImageUploadEditor;

            initFormType(SubjectForm, [
                'CourseId', w0,
                'Title', w1,
                'Description', w2,
                'SortOrder', w3,
                'ClassId', w0,
                'SemesterId', w0,
                'Weightage', w4,
                'Thumbnail', w5
            ]);
        }
    }
}