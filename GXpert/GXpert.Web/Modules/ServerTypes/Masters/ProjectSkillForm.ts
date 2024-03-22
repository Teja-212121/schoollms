import { LookupEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ProjectSkillForm {
    SkillCategoryId: LookupEditor;
    SkillId: LookupEditor;
    ProjectId: IntegerEditor;
}

export class ProjectSkillForm extends PrefixedContext {
    static readonly formKey = 'Masters.ProjectSkill';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProjectSkillForm.init)  {
            ProjectSkillForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;

            initFormType(ProjectSkillForm, [
                'SkillCategoryId', w0,
                'SkillId', w0,
                'ProjectId', w1
            ]);
        }
    }
}