import { StringEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignmentForm {
    Title: StringEditor;
    Description: StringEditor;
    File: StringEditor;
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
            var w1 = LookupEditor;

            initFormType(AssignmentForm, [
                'Title', w0,
                'Description', w0,
                'File', w0,
                'ClassId', w1,
                'SubjectId', w1
            ]);
        }
    }
}