import { StringEditor, LookupEditor, EnumEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EKeyStatus } from "../Web/Enums.EKeyStatus";
import { EValidityType } from "../Web/Enums.EValidityType";

export interface SerialKeyForm {
    SerialKey: StringEditor;
    PlayListId: LookupEditor;
    ValidityType: EnumEditor;
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
            var w2 = EnumEditor;
            var w3 = IntegerEditor;
            var w4 = DateEditor;

            initFormType(SerialKeyForm, [
                'SerialKey', w0,
                'PlayListId', w1,
                'ValidityType', w2,
                'ValidityInDays', w3,
                'ValidDate', w4,
                'Note', w0,
                'EStatus', w2
            ]);
        }
    }
}

[EValidityType, EKeyStatus]; // referenced types