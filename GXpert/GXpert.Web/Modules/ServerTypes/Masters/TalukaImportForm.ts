import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TalukaImportForm {
    FileName: ImageUploadEditor;
}

export class TalukaImportForm extends PrefixedContext {
    static readonly formKey = 'Masters.TalukaImportForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TalukaImportForm.init)  {
            TalukaImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(TalukaImportForm, [
                'FileName', w0
            ]);
        }
    }
}