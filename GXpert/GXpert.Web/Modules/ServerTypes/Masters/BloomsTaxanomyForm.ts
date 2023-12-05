import { StringEditor, IntegerEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface BloomsTaxanomyForm {
    CoginitiveSkill: StringEditor;
    SortOrder: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class BloomsTaxanomyForm extends PrefixedContext {
    static readonly formKey = 'Masters.BloomsTaxanomy';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BloomsTaxanomyForm.init)  {
            BloomsTaxanomyForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(BloomsTaxanomyForm, [
                'CoginitiveSkill', w0,
                'SortOrder', w1,
                'InsertDate', w2,
                'InsertUserId', w1,
                'UpdateDate', w2,
                'UpdateUserId', w1,
                'IsActive', w3
            ]);
        }
    }
}