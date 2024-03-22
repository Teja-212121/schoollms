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
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ProjectSkillRow>();
}