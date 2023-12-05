import { IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface RaiseHandLiveSessionForm {
    LiveSessionlogId: IntegerEditor;
    StudentId: IntegerEditor;
    SessionTime: DateEditor;
    HandRaiseStatus: IntegerEditor;
    PlayListId: IntegerEditor;
    ActivationId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class RaiseHandLiveSessionForm extends PrefixedContext {
    static readonly formKey = 'Attendance.RaiseHandLiveSession';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!RaiseHandLiveSessionForm.init)  {
            RaiseHandLiveSessionForm.init = true;

            var w0 = IntegerEditor;
            var w1 = DateEditor;
            var w2 = BooleanEditor;

            initFormType(RaiseHandLiveSessionForm, [
                'LiveSessionlogId', w0,
                'StudentId', w0,
                'SessionTime', w1,
                'HandRaiseStatus', w0,
                'PlayListId', w0,
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