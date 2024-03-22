import { LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface UserSkillsScoreForm {
    SkillCategoryId: LookupEditor;
    SkillId: LookupEditor;
}

export class UserSkillsScoreForm extends PrefixedContext {
    static readonly formKey = 'Masters.UserSkillsScore';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UserSkillsScoreForm.init)  {
            UserSkillsScoreForm.init = true;

            var w0 = LookupEditor;

            initFormType(UserSkillsScoreForm, [
                'SkillCategoryId', w0,
                'SkillId', w0
            ]);
        }
    }
}