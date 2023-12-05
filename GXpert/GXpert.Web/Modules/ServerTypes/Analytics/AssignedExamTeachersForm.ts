import { IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AssignedExamTeachersForm {
    ExamId: IntegerEditor;
    PlayListId: IntegerEditor;
    TeacherId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class AssignedExamTeachersForm extends PrefixedContext {
    static readonly formKey = 'Analytics.AssignedExamTeachers';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AssignedExamTeachersForm.init)  {
            AssignedExamTeachersForm.init = true;

            var w0 = IntegerEditor;
            var w1 = DateEditor;
            var w2 = BooleanEditor;

            initFormType(AssignedExamTeachersForm, [
                'ExamId', w0,
                'PlayListId', w0,
                'TeacherId', w0,
                'InsertDate', w1,
                'InsertUserId', w0,
                'UpdateDate', w1,
                'UpdateUserId', w0,
                'IsActive', w2
            ]);
        }
    }
}