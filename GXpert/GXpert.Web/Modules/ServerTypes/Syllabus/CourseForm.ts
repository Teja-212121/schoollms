import { StringEditor, IntegerEditor, ImageUploadEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CourseForm {
    Title: StringEditor;
    SortOrder: IntegerEditor;
    Thumbnail: ImageUploadEditor;
    Description: TextAreaEditor;
}

export class CourseForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Course';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CourseForm.init)  {
            CourseForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = ImageUploadEditor;
            var w3 = TextAreaEditor;

            initFormType(CourseForm, [
                'Title', w0,
                'SortOrder', w1,
                'Thumbnail', w2,
                'Description', w3
            ]);
        }
    }
}