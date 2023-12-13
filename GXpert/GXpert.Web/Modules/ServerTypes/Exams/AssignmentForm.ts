import { StringEditor, TextAreaEditor, ImageUploadEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignmentForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    File: ImageUploadEditor;
    ClassId: LookupEditor;
    SubjectId: LookupEditor;
}

export class AssignmentForm extends PrefixedContext {
    static readonly formKey = 'Exams.Assignment';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AssignmentForm.init)  {
            AssignmentForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = ImageUploadEditor;
            var w3 = LookupEditor;

            initFormType(AssignmentForm, [
                'Title', w0,
                'Description', w1,
                'File', w2,
                'ClassId', w3,
                'SubjectId', w3
            ]);
        }
    }
}