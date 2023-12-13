import { StringEditor, TextAreaEditor, ServiceLookupEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ModuleForm {
    Title: StringEditor;
    Description: TextAreaEditor;
    ParentId: ServiceLookupEditor;
    SortOrder: DecimalEditor;
}

export class ModuleForm extends PrefixedContext {
    static readonly formKey = 'Playlist.Module';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ModuleForm.init)  {
            ModuleForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = ServiceLookupEditor;
            var w3 = DecimalEditor;

            initFormType(ModuleForm, [
                'Title', w0,
                'Description', w1,
                'ParentId', w2,
                'SortOrder', w3
            ]);
        }
    }
}