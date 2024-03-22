import { LookupEditor, ServiceLookupEditor, StringEditor, DateEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EKeyStatus } from "../Web/Enums.EKeyStatus";

export interface ActivationForm {
    PlayListId: LookupEditor;
    TeacherId: LookupEditor;
    ActivationLogId: ServiceLookupEditor;
    DeviceId: StringEditor;
    DeviceDetails: StringEditor;
    ActivationDate: DateEditor;
    ExpiryDate: DateEditor;
    EStatus: EnumEditor;
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
            var w4 = EnumEditor;

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

[EKeyStatus]; // referenced types