import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface InstituteTimeTableExcelImportForm {
    FileName: ImageUploadEditor;
}

export class InstituteTimeTableExcelImportForm extends PrefixedContext {
    static readonly formKey = 'Institute.InstituteTimeTableExcelImportForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteTimeTableExcelImportForm.init)  {
            InstituteTimeTableExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(InstituteTimeTableExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}