import { IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignmentAttemptForm {
    AssignmentId: IntegerEditor;
    StudentId: IntegerEditor;
    FileUploaded: StringEditor;
    EStatus: StringEditor;
    TeacherId: IntegerEditor;
    PlayListId: IntegerEditor;
    ActivationId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class AssignmentAttemptForm extends PrefixedContext {
    static readonly formKey = 'Attendance.AssignmentAttempt';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AssignmentAttemptForm.init)  {
            AssignmentAttemptForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(AssignmentAttemptForm, [
                'AssignmentId', w0,
                'StudentId', w0,
                'FileUploaded', w1,
                'EStatus', w1,
                'TeacherId', w0,
                'PlayListId', w0,
                'ActivationId', w0,
                'InsertDate', w2,
                'InsertUserId', w0,
                'UpdateDate', w2,
                'UpdateUserId', w0,
                'IsActive', w3
            ]);
        }
    }
}