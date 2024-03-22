import { ServiceLookupEditor, StringEditor, TextAreaEditor, IntegerEditor, DecimalEditor, ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ClassForm {
    CourseId: ServiceLookupEditor;
    Title: StringEditor;
    Description: TextAreaEditor;
    SortOrder: IntegerEditor;
    Weightage: DecimalEditor;
    Thumbnail: ImageUploadEditor;
}

export class ClassForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Class';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ClassForm.init)  {
            ClassForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = IntegerEditor;
            var w4 = DecimalEditor;
            var w5 = ImageUploadEditor;

            initFormType(ClassForm, [
                'CourseId', w0,
                'Title', w1,
                'Description', w2,
                'SortOrder', w3,
                'Weightage', w4,
                'Thumbnail', w5
            ]);
        }
    }
}