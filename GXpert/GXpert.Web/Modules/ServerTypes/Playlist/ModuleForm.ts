import { StringEditor, ServiceLookupEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ModuleForm {
    Title: StringEditor;
    Description: StringEditor;
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
            var w1 = ServiceLookupEditor;
            var w2 = DecimalEditor;

            initFormType(ModuleForm, [
                'Title', w0,
                'Description', w0,
                'ParentId', w1,
                'SortOrder', w2
            ]);
        }
    }
}