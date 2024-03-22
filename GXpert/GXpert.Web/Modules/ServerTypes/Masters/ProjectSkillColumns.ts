import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ProjectSkillRow } from "./ProjectSkillRow";

export interface ProjectSkillColumns {
    Id: Column<ProjectSkillRow>;
    SkillCategoryName: Column<ProjectSkillRow>;
    SkillName: Column<ProjectSkillRow>;
    ProjectTitle: Column<ProjectSkillRow>;
}

export class ProjectSkillColumns extends ColumnsBase<ProjectSkillRow> {
    static readonly columnsKey = 'Masters.ProjectSkill';
    static readonly Fields = fieldsProxy<ProjectSkillColumns>();
}