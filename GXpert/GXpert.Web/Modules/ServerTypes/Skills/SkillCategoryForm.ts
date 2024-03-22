import { StringEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SkillCategoryForm {
    Name: StringEditor;
    Description: TextAreaEditor;
}

export class SkillCategoryForm extends PrefixedContext {
    static readonly formKey = 'Skills.SkillCategory';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SkillCategoryForm.init)  {
            SkillCategoryForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;

            initFormType(SkillCategoryForm, [
                'Name', w0,
                'Description', w1
            ]);
        }
    }
}