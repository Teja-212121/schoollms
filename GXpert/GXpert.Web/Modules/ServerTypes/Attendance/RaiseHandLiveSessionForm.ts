import { IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface RaiseHandLiveSessionForm {
    LiveSessionlogId: IntegerEditor;
    StudentId: IntegerEditor;
    SessionTime: DateEditor;
    HandRaiseStatus: IntegerEditor;
    PlayListId: IntegerEditor;
    ActivationId: IntegerEditor;
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

            initFormType(RaiseHandLiveSessionForm, [
                'LiveSessionlogId', w0,
                'StudentId', w0,
                'SessionTime', w1,
                'HandRaiseStatus', w0,
                'PlayListId', w0,
                'ActivationId', w0
            ]);
        }
    }
}