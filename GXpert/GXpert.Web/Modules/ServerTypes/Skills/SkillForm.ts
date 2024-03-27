import { LookupEditor, StringEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SkillForm {
    SkillCategoryId: LookupEditor;
    Name: StringEditor;
    Description: TextAreaEditor;
}

export class SkillForm extends PrefixedContext {
    static readonly formKey = 'Skills.Skill';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SkillForm.init)  {
            SkillForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;

            initFormType(SkillForm, [
                'SkillCategoryId', w0,
                'Name', w1,
                'Description', w2
            ]);
        }
    }
}