import { fieldsProxy } from "@serenity-is/corelib";

export interface ProjectSkillRow {
    Id?: number;
    SkillCategoryId?: number;
    SkillId?: number;
    ProjectId?: number;
    SkillCategoryName?: string;
    SkillName?: string;
    ProjectTitle?: string;
}

export abstract class ProjectSkillRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Masters.ProjectSkill';
    static readonly deletePermission = 'Masters:MastersManagement:Modify';
    static readonly insertPermission = 'Masters:MastersManagement:Modify';
    static readonly readPermission = 'Masters:MastersManagement:View';
    static readonly updatePermission = 'Masters:MastersManagement:Modify';

    static readonly Fields = fieldsProxy<ProjectSkillRow>();
}