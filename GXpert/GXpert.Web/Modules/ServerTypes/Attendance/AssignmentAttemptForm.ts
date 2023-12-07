import { LookupEditor, ImageUploadEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EExamAttemptStatus } from "../Web/Enums.EExamAttemptStatus";

export interface AssignmentAttemptForm {
    AssignmentId: LookupEditor;
    StudentId: LookupEditor;
    FileUploaded: ImageUploadEditor;
    EStatus: EnumEditor;
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
            var w1 = ImageUploadEditor;
            var w2 = EnumEditor;

            initFormType(AssignmentAttemptForm, [
                'AssignmentId', w0,
                'StudentId', w0,
                'FileUploaded', w1,
                'EStatus', w2,
                'TeacherId', w0,
                'PlayListId', w0,
                'ActivationId', w0
            ]);
        }
    }
}

[EExamAttemptStatus]; // referenced types