import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AcademicSubjectPerformanceImportForm {
    FileName: ImageUploadEditor;
}

export class AcademicSubjectPerformanceImportForm extends PrefixedContext {
    static readonly formKey = 'Masters.AcademicSubjectPerformanceImportForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicSubjectPerformanceImportForm.init)  {
            AcademicSubjectPerformanceImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(AcademicSubjectPerformanceImportForm, [
                'FileName', w0
            ]);
        }
    }
}