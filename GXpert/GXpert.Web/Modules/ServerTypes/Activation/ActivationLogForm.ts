import { StringEditor, LookupEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EKeyStatus } from "../Web/Enums.EKeyStatus";

export interface ActivationLogForm {
    Code: StringEditor;
    SerialKey: StringEditor;
    TeacherId: LookupEditor;
    PlayListId: LookupEditor;
    DeviceId: StringEditor;
    DeviceDetails: StringEditor;
    EStatus: EnumEditor;
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
            var w1 = LookupEditor;
            var w2 = EnumEditor;

            initFormType(ActivationLogForm, [
                'Code', w0,
                'SerialKey', w0,
                'TeacherId', w1,
                'PlayListId', w1,
                'DeviceId', w0,
                'DeviceDetails', w0,
                'EStatus', w2,
                'Note', w0
            ]);
        }
    }
}

[EKeyStatus]; // referenced types