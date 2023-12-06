import { StringEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ActivationLogForm {
    Code: StringEditor;
    SerialKey: StringEditor;
    TeacherId: IntegerEditor;
    PlayListId: IntegerEditor;
    DeviceId: StringEditor;
    DeviceDetails: StringEditor;
    EStatus: IntegerEditor;
    Note: StringEditor;
}

export class ActivationLogForm extends PrefixedContext {
    static readonly formKey = 'Activation.ActivationLog';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ActivationLogForm.init)  {
            ActivationLogForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(ActivationLogForm, [
                'Code', w0,
                'SerialKey', w0,
                'TeacherId', w1,
                'PlayListId', w1,
                'DeviceId', w0,
                'DeviceDetails', w0,
                'EStatus', w1,
                'Note', w0
            ]);
        }
    }
}