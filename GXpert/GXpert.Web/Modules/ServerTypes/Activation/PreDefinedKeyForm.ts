import { StringEditor, EnumEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EPreDefinedKeyStatus } from "../Rio/Web.Enums.EPreDefinedKeyStatus";

export interface PreDefinedKeyForm {
    SerialKey: StringEditor;
    EStatus: EnumEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
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
            var w2 = DateEditor;
            var w3 = IntegerEditor;

            initFormType(PreDefinedKeyForm, [
                'SerialKey', w0,
                'EStatus', w1,
                'InsertDate', w2,
                'InsertUserId', w3,
                'UpdateDate', w2,
                'UpdateUserId', w3,
                'IsActive', w3
            ]);
        }
    }
}

[EPreDefinedKeyStatus]; // referenced types