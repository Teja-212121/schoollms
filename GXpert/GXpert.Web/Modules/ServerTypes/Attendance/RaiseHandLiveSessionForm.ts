import { LookupEditor, DateEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EHandRaiseStatus } from "../Web/Enums.EHandRaiseStatus";

export interface RaiseHandLiveSessionForm {
    LiveSessionlogId: LookupEditor;
    StudentId: LookupEditor;
    SessionTime: DateEditor;
    HandRaiseStatus: EnumEditor;
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
            var w2 = EnumEditor;

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

[EHandRaiseStatus]; // referenced types