import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SkillRow } from "./SkillRow";

export interface SkillColumns {
    Id: Column<SkillRow>;
    Name: Column<SkillRow>;
    Description: Column<SkillRow>;
    SkillCategoryName: Column<SkillRow>;
}

export class SkillColumns extends ColumnsBase<SkillRow> {
    static readonly columnsKey = 'Skills.Skill';
    static readonly Fields = fieldsProxy<SkillColumns>();
}