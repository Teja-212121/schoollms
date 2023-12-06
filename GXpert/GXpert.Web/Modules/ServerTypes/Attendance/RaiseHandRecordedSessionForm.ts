import { IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface RaiseHandRecordedSessionForm {
    ContentId: IntegerEditor;
    StudentId: IntegerEditor;
    PlayListId: IntegerEditor;
    PlayListContentId: IntegerEditor;
    ActivationId: IntegerEditor;
}

export class RaiseHandRecordedSessionForm extends PrefixedContext {
    static readonly formKey = 'Attendance.RaiseHandRecordedSession';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!RaiseHandRecordedSessionForm.init)  {
            RaiseHandRecordedSessionForm.init = true;

            var w0 = IntegerEditor;

            initFormType(RaiseHandRecordedSessionForm, [
                'ContentId', w0,
                'StudentId', w0,
                'PlayListId', w0,
                'PlayListContentId', w0,
                'ActivationId', w0
            ]);
        }
    }
}