import { LookupEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface RaiseHandLiveSessionForm {
    LiveSessionlogId: LookupEditor;
    StudentId: LookupEditor;
    SessionTime: DateEditor;
    HandRaiseStatus: IntegerEditor;
    PlayListId: LookupEditor;
    ActivationId: LookupEditor;
}

export class RaiseHandLiveSessionForm extends PrefixedContext {
    static readonly formKey = 'Attendance.RaiseHandLiveSession';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!RaiseHandLiveSessionForm.init)  {
            RaiseHandLiveSessionForm.init = true;

            var w0 = LookupEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;

            initFormType(RaiseHandLiveSessionForm, [
                'LiveSessionlogId', w0,
                'StudentId', w0,
                'SessionTime', w1,
                'HandRaiseStatus', w2,
                'PlayListId', w0,
                'ActivationId', w0
            ]);
        }
    }
}