import { LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignedExamTeachersForm {
    ExamId: LookupEditor;
    PlayListId: LookupEditor;
    TeacherId: LookupEditor;
}

export class AssignedExamTeachersForm extends PrefixedContext {
    static readonly formKey = 'Analytics.AssignedExamTeachers';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AssignedExamTeachersForm.init)  {
            AssignedExamTeachersForm.init = true;

            var w0 = LookupEditor;

            initFormType(AssignedExamTeachersForm, [
                'ExamId', w0,
                'PlayListId', w0,
                'TeacherId', w0
            ]);
        }
    }
}