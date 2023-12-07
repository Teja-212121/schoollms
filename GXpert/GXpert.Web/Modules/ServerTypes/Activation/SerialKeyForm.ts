import { StringEditor, LookupEditor, IntegerEditor, DateEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EKeyStatus } from "../Web/Enums.EKeyStatus";

export interface SerialKeyForm {
    SerialKey: StringEditor;
    PlayListId: LookupEditor;
    ValidityType: IntegerEditor;
    ValidityInDays: IntegerEditor;
    ValidDate: DateEditor;
    Note: StringEditor;
    EStatus: EnumEditor;
}

export class SerialKeyForm extends PrefixedContext {
    static readonly formKey = 'Activation.SerialKey';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SerialKeyForm.init)  {
            SerialKeyForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = IntegerEditor;
            var w3 = DateEditor;
            var w4 = EnumEditor;

            initFormType(SerialKeyForm, [
                'SerialKey', w0,
                'PlayListId', w1,
                'ValidityType', w2,
                'ValidityInDays', w2,
                'ValidDate', w3,
                'Note', w0,
                'EStatus', w4
            ]);
        }
    }
}

[EKeyStatus]; // referenced types