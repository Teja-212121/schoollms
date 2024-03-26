import { StringEditor, TextAreaEditor, ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PreAcademicForm {
    ExamName: StringEditor;
    Description: TextAreaEditor;
    Thumbnail: ImageUploadEditor;
}

export class PreAcademicForm extends PrefixedContext {
    static readonly formKey = 'Masters.PreAcademic';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PreAcademicForm.init)  {
            PreAcademicForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = ImageUploadEditor;

            initFormType(PreAcademicForm, [
                'ExamName', w0,
                'Description', w1,
                'Thumbnail', w2
            ]);
        }
    }
}