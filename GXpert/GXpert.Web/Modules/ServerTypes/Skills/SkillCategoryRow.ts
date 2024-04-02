import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface SkillCategoryRow {
    Id?: number;
    Name?: string;
    Description?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class SkillCategoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Skills.SkillCategory';
    static readonly lookupKey = 'Skills.SkillCategory';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<SkillCategoryRow>('Skills.SkillCategory') }
    static async getLookupAsync() { return getLookupAsync<SkillCategoryRow>('Skills.SkillCategory') }

    static readonly deletePermission = 'Skills:SkillsManagement:Modify';
    static readonly insertPermission = 'Skills:SkillsManagement:Modify';
    static readonly readPermission = 'Skills:SkillsManagement:View';
    static readonly updatePermission = 'Skills:SkillsManagement:Modify';

    static readonly Fields = fieldsProxy<SkillCategoryRow>();
}