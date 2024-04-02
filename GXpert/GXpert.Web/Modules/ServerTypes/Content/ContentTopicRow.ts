import { fieldsProxy } from "@serenity-is/corelib";

export interface ContentTopicRow {
    Id?: number;
    ContentId?: number;
    ClassId?: number;
    SubjectId?: number;
    TopicId?: number;
    MediumId?: number;
    SortOrder?: number;
    IsActive?: boolean;
    ContentTitle?: string;
    ClassTitle?: string;
    SubjectTitle?: string;
    TopicTitle?: string;
    MediumTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentTopicRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Content.ContentTopic';
    static readonly deletePermission = 'Content:ContentManagement:View';
    static readonly insertPermission = 'Content:ContentManagement:View';
    static readonly readPermission = 'Content:ContentManagement:View';
    static readonly updatePermission = 'Content:ContentManagement:View';

    static readonly Fields = fieldsProxy<ContentTopicRow>();
}