import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PreAcademicScoreImportForm {
    FileName: ImageUploadEditor;
}

export class PreAcademicScoreImportForm extends PrefixedContext {
    static readonly formKey = 'Masters.PreAcademicScoreImportForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PreAcademicScoreImportForm.init)  {
            PreAcademicScoreImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(PreAcademicScoreImportForm, [
                'FileName', w0
            ]);
        }
    }
}