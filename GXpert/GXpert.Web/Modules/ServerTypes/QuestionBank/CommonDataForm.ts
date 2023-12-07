import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CommonDataForm {
    CommonDataTitle: StringEditor;
    CommonData: StringEditor;
}

export class CommonDataForm extends PrefixedContext {
    static readonly formKey = 'QuestionBank.CommonData';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CommonDataForm.init)  {
            CommonDataForm.init = true;

            var w0 = StringEditor;

            initFormType(CommonDataForm, [
                'CommonDataTitle', w0,
                'CommonData', w0
            ]);
        }
    }
}