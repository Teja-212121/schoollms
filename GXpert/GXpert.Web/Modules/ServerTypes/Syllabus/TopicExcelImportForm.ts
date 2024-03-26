import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TopicExcelImportForm {
    FileName: ImageUploadEditor;
}

export class TopicExcelImportForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.TopicExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TopicExcelImportForm.init)  {
            TopicExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(TopicExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}