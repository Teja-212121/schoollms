import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PreAcademicForm {
    ExamName: StringEditor;
    Description: StringEditor;
    Thumbnail: StringEditor;
}

export class PreAcademicForm extends PrefixedContext {
    static readonly formKey = 'Masters.PreAcademic';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PreAcademicForm.init)  {
            PreAcademicForm.init = true;

            var w0 = StringEditor;

            initFormType(PreAcademicForm, [
                'ExamName', w0,
                'Description', w0,
                'Thumbnail', w0
            ]);
        }
    }
}