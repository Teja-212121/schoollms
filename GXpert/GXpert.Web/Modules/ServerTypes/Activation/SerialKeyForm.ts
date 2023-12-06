import { StringEditor, LookupEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SerialKeyForm {
    SerialKey: StringEditor;
    PlayListId: LookupEditor;
    ValidityType: IntegerEditor;
    ValidityInDays: IntegerEditor;
    ValidDate: DateEditor;
    Note: StringEditor;
    EStatus: IntegerEditor;
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

            initFormType(SerialKeyForm, [
                'SerialKey', w0,
                'PlayListId', w1,
                'ValidityType', w2,
                'ValidityInDays', w2,
                'ValidDate', w3,
                'Note', w0,
                'EStatus', w2
            ]);
        }
    }
}