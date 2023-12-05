import { fieldsProxy } from "@serenity-is/corelib";

export interface PollRow {
    Id?: number;
    Question?: string;
    EQuestionType?: number;
    Option1?: string;
    Option2?: string;
    Option3?: string;
    Option4?: string;
    Option5?: string;
    RightAnswer?: string;
    LiveSessionLogId?: number;
    TotalAttempts?: number;
    NumberOfCorrect?: number;
    NumberOfWrong?: number;
    BloomsTaxonomyId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    BloomsTaxonomyCoginitiveSkill?: string;
}

export abstract class PollRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Question';
    static readonly localTextPrefix = 'LiveSessions.Poll';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PollRow>();
}