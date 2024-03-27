import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DistrictImportForm {
    FileName: ImageUploadEditor;
}

export class DistrictImportForm extends PrefixedContext {
    static readonly formKey = 'Masters.DistrictImportForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DistrictImportForm.init)  {
            DistrictImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(DistrictImportForm, [
                'FileName', w0
            ]);
        }
    }
}