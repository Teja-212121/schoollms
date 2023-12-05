import { StringEditor, ServiceLookupEditor, DecimalEditor, DateEditor, IntegerEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ModuleForm {
    Title: StringEditor;
    Description: StringEditor;
    ParentId: ServiceLookupEditor;
    SortOrder: DecimalEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
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
            var w3 = DateEditor;
            var w4 = IntegerEditor;
            var w5 = BooleanEditor;

            initFormType(ModuleForm, [
                'Title', w0,
                'Description', w0,
                'ParentId', w1,
                'SortOrder', w2,
                'InsertDate', w3,
                'InsertUserId', w4,
                'UpdateDate', w3,
                'UpdateUserId', w4,
                'IsActive', w5
            ]);
        }
    }
}