import { StringEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ActivationLogForm {
    Code: StringEditor;
    SerialKey: StringEditor;
    TeacherId: IntegerEditor;
    PlayListId: IntegerEditor;
    DeviceId: StringEditor;
    DeviceDetails: StringEditor;
    EStatus: IntegerEditor;
    Note: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
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
            var w2 = DateEditor;

            initFormType(ActivationLogForm, [
                'Code', w0,
                'SerialKey', w0,
                'TeacherId', w1,
                'PlayListId', w1,
                'DeviceId', w0,
                'DeviceDetails', w0,
                'EStatus', w1,
                'Note', w0,
                'InsertDate', w2,
                'InsertUserId', w1,
                'UpdateDate', w2,
                'UpdateUserId', w1,
                'IsActive', w1
            ]);
        }
    }
}