import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SubjectExcelImportForm {
    FileName: ImageUploadEditor;
}

export class SubjectExcelImportForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.SubjectExelImportForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SubjectExcelImportForm.init)  {
            SubjectExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(SubjectExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}