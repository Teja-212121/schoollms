import { StringEditor, ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PreAcademicForm {
    ExamName: StringEditor;
    Description: StringEditor;
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
            var w1 = ImageUploadEditor;

            initFormType(PreAcademicForm, [
                'ExamName', w0,
                'Description', w0,
                'Thumbnail', w1
            ]);
        }
    }
}