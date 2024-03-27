import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { UserSkillsScoreRow } from "./UserSkillsScoreRow";

export interface UserSkillsScoreColumns {
    Id: Column<UserSkillsScoreRow>;
    SkillCategoryName: Column<UserSkillsScoreRow>;
    SkillName: Column<UserSkillsScoreRow>;
    Score: Column<UserSkillsScoreRow>;
}

export class UserSkillsScoreColumns extends ColumnsBase<UserSkillsScoreRow> {
    static readonly columnsKey = 'Masters.UserSkillsScore';
    static readonly Fields = fieldsProxy<UserSkillsScoreColumns>();
}