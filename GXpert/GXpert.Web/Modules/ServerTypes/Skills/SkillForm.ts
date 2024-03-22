import { StringEditor, TextAreaEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SkillForm {
    Name: StringEditor;
    Description: TextAreaEditor;
    SkillCategoryId: LookupEditor;
}

export class SkillForm extends PrefixedContext {
    static readonly formKey = 'Skills.Skill';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SkillForm.init)  {
            SkillForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = LookupEditor;

            initFormType(SkillForm, [
                'Name', w0,
                'Description', w1,
                'SkillCategoryId', w2
            ]);
        }
    }
}