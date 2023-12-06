import { LookupEditor, ServiceLookupEditor, StringEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ActivationForm {
    PlayListId: LookupEditor;
    TeacherId: LookupEditor;
    ActivationLogId: ServiceLookupEditor;
    DeviceId: StringEditor;
    DeviceDetails: StringEditor;
    ActivationDate: DateEditor;
    ExpiryDate: DateEditor;
    EStatus: IntegerEditor;
}

export class ActivationForm extends PrefixedContext {
    static readonly formKey = 'Activation.Activation';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ActivationForm.init)  {
            ActivationForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = StringEditor;
            var w3 = DateEditor;
            var w4 = IntegerEditor;

            initFormType(ActivationForm, [
                'PlayListId', w0,
                'TeacherId', w0,
                'ActivationLogId', w1,
                'DeviceId', w2,
                'DeviceDetails', w2,
                'ActivationDate', w3,
                'ExpiryDate', w3,
                'EStatus', w4
            ]);
        }
    }
}