import { IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface RaiseHandRecordedSessionForm {
    ContentId: IntegerEditor;
    StudentId: IntegerEditor;
    PlayListId: IntegerEditor;
    PlayListContentId: IntegerEditor;
    ActivationId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class RaiseHandRecordedSessionForm extends PrefixedContext {
    static readonly formKey = 'Attendance.RaiseHandRecordedSession';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!RaiseHandRecordedSessionForm.init)  {
            RaiseHandRecordedSessionForm.init = true;

            var w0 = IntegerEditor;
            var w1 = DateEditor;
            var w2 = BooleanEditor;

            initFormType(RaiseHandRecordedSessionForm, [
                'ContentId', w0,
                'StudentId', w0,
                'PlayListId', w0,
                'PlayListContentId', w0,
                'ActivationId', w0,
                'InsertDate', w1,
                'InsertUserId', w0,
                'UpdateDate', w1,
                'UpdateUserId', w0,
                'IsActive', w2
            ]);
        }
    }
}