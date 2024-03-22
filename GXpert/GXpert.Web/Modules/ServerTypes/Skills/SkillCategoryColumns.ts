import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SkillCategoryRow } from "./SkillCategoryRow";

export interface SkillCategoryColumns {
    Id: Column<SkillCategoryRow>;
    Name: Column<SkillCategoryRow>;
    Description: Column<SkillCategoryRow>;
}

export class SkillCategoryColumns extends ColumnsBase<SkillCategoryRow> {
    static readonly columnsKey = 'Skills.SkillCategory';
    static readonly Fields = fieldsProxy<SkillCategoryColumns>();
}