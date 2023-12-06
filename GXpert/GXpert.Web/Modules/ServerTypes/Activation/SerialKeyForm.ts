import { StringEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SerialKeyForm {
    SerialKey: StringEditor;
    PlayListId: IntegerEditor;
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
            var w1 = IntegerEditor;
            var w2 = DateEditor;

            initFormType(SerialKeyForm, [
                'SerialKey', w0,
                'PlayListId', w1,
                'ValidityType', w1,
                'ValidityInDays', w1,
                'ValidDate', w2,
                'Note', w0,
                'EStatus', w1
            ]);
        }
    }
}