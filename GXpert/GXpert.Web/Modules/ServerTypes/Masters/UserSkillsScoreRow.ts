import { fieldsProxy } from "@serenity-is/corelib";

export interface UserSkillsScoreRow {
    Id?: number;
    SkillCategoryId?: number;
    SkillId?: number;
    Score?: number;
    SkillCategoryName?: string;
    SkillName?: string;
}

export abstract class UserSkillsScoreRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Masters.UserSkillsScore';
    static readonly deletePermission = 'Masters:MastersManagement:Modify';
    static readonly insertPermission = 'Masters:MastersManagement:Modify';
    static readonly readPermission = 'Masters:MastersManagement:View';
    static readonly updatePermission = 'Masters:MastersManagement:Modify';

    static readonly Fields = fieldsProxy<UserSkillsScoreRow>();
}