import { fieldsProxy } from "@serenity-is/corelib";

export interface UserSkillsScoreRow {
    Id?: number;
    SkillCategoryId?: number;
    SkillId?: number;
    SkillCategoryName?: string;
    SkillName?: string;
}

export abstract class UserSkillsScoreRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Masters.UserSkillsScore';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<UserSkillsScoreRow>();
}