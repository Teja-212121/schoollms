import { ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface StudentImportForm {
    FileName: ImageUploadEditor;
}

export class StudentImportForm extends PrefixedContext {
    static readonly formKey = 'Users.StudentImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StudentImportForm.init)  {
            StudentImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(StudentImportForm, [
                'FileName', w0
            ]);
        }
    }
}