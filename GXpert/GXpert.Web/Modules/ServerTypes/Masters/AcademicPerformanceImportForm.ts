import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AcademicPerformanceImportForm {
    FileName: ImageUploadEditor;
}

export class AcademicPerformanceImportForm extends PrefixedContext {
    static readonly formKey = 'Masters.AcademicPerformanceImportForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicPerformanceImportForm.init)  {
            AcademicPerformanceImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(AcademicPerformanceImportForm, [
                'FileName', w0
            ]);
        }
    }
}