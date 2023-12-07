import { StringEditor, DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface StateForm {
    Title: StringEditor;
    ShortName: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class StateForm extends PrefixedContext {
    static readonly formKey = 'Masters.State';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StateForm.init)  {
            StateForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;
            var w3 = BooleanEditor;

            initFormType(StateForm, [
                'Title', w0,
                'ShortName', w0,
                'InsertDate', w1,
                'InsertUserId', w2,
                'UpdateDate', w1,
                'UpdateUserId', w2,
                'IsActive', w3
            ]);
        }
    }
}