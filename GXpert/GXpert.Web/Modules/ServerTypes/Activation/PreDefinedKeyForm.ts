import { StringEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EPreDefinedKeyStatus } from "../Rio/Web.Enums.EPreDefinedKeyStatus";

export interface PreDefinedKeyForm {
    SerialKey: StringEditor;
    EStatus: EnumEditor;
}

export class PreDefinedKeyForm extends PrefixedContext {
    static readonly formKey = 'Activation.PreDefinedKey';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PreDefinedKeyForm.init)  {
            PreDefinedKeyForm.init = true;

            var w0 = StringEditor;
            var w1 = EnumEditor;

            initFormType(PreDefinedKeyForm, [
                'SerialKey', w0,
                'EStatus', w1
            ]);
        }
    }
}

[EPreDefinedKeyStatus]; // referenced types