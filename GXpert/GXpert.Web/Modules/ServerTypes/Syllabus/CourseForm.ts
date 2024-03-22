import { StringEditor, TextAreaEditor, IntegerEditor, ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CourseForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    SortOrder: IntegerEditor;
    Thumbnail: ImageUploadEditor;
}

export class CourseForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Course';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CourseForm.init)  {
            CourseForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = IntegerEditor;
            var w3 = ImageUploadEditor;

            initFormType(CourseForm, [
                'Title', w0,
                'Description', w1,
                'SortOrder', w2,
                'Thumbnail', w3
            ]);
        }
    }
}