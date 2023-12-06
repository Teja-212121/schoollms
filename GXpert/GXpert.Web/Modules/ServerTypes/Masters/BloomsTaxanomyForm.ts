import { StringEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface BloomsTaxanomyForm {
    CoginitiveSkill: StringEditor;
    SortOrder: IntegerEditor;
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

            initFormType(BloomsTaxanomyForm, [
                'CoginitiveSkill', w0,
                'SortOrder', w1
            ]);
        }
    }
}