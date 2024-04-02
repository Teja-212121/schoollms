import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface SkillRow {
    Id?: number;
    Name?: string;
    Description?: string;
    SkillCategoryId?: number;
    IsActive?: boolean;
    SkillCategoryName?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class SkillRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Skills.Skill';
    static readonly lookupKey = 'Skills.Skill';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<SkillRow>('Skills.Skill') }
    static async getLookupAsync() { return getLookupAsync<SkillRow>('Skills.Skill') }

    static readonly deletePermission = 'Skills:SkillsManagement:Modify';
    static readonly insertPermission = 'Skills:SkillsManagement:Modify';
    static readonly readPermission = 'Skills:SkillsManagement:View';
    static readonly updatePermission = 'Skills:SkillsManagement:Modify';

    static readonly Fields = fieldsProxy<SkillRow>();
}