import { LookupEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface UserSkillsScoreForm {
    SkillCategoryId: LookupEditor;
    SkillId: LookupEditor;
    Score: DecimalEditor;
}

export class UserSkillsScoreForm extends PrefixedContext {
    static readonly formKey = 'Masters.UserSkillsScore';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UserSkillsScoreForm.init)  {
            UserSkillsScoreForm.init = true;

            var w0 = LookupEditor;
            var w1 = DecimalEditor;

            initFormType(UserSkillsScoreForm, [
                'SkillCategoryId', w0,
                'SkillId', w0,
                'Score', w1
            ]);
        }
    }
}