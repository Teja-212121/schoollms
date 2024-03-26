import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface StateImportForm {
    FileName: ImageUploadEditor;
}

export class StateImportForm extends PrefixedContext {
    static readonly formKey = 'Masters.StateImportForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StateImportForm.init)  {
            StateImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(StateImportForm, [
                'FileName', w0
            ]);
        }
    }
}