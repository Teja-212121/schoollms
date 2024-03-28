import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface QuestionExcellmportForm {
    FileName: ImageUploadEditor;
}

export class QuestionExcellmportForm extends PrefixedContext {
    static readonly formKey = 'QuestionBank.QuestionExcellmportForm';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!QuestionExcellmportForm.init)  {
            QuestionExcellmportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(QuestionExcellmportForm, [
                'FileName', w0
            ]);
        }
    }
}