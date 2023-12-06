import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface StateForm {
    Title: StringEditor;
    ShortName: StringEditor;
}

export class StateForm extends PrefixedContext {
    static readonly formKey = 'Masters.State';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StateForm.init)  {
            StateForm.init = true;

            var w0 = StringEditor;

            initFormType(StateForm, [
                'Title', w0,
                'ShortName', w0
            ]);
        }
    }
}