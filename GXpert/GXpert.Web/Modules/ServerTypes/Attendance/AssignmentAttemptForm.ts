import { LookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignmentAttemptForm {
    AssignmentId: LookupEditor;
    StudentId: LookupEditor;
    FileUploaded: StringEditor;
    EStatus: StringEditor;
    TeacherId: LookupEditor;
    PlayListId: LookupEditor;
    ActivationId: LookupEditor;
}

export class AssignmentAttemptForm extends PrefixedContext {
    static readonly formKey = 'Attendance.AssignmentAttempt';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AssignmentAttemptForm.init)  {
            AssignmentAttemptForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;

            initFormType(AssignmentAttemptForm, [
                'AssignmentId', w0,
                'StudentId', w0,
                'FileUploaded', w1,
                'EStatus', w1,
                'TeacherId', w0,
                'PlayListId', w0,
                'ActivationId', w0
            ]);
        }
    }
}