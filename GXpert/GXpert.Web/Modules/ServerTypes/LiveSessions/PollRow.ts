import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";
import { EQuestionType } from "../Web/Enums.EQuestionType";

export interface PollRow {
    Id?: number;
    Question?: string;
    EQuestionType?: EQuestionType;
    Option1?: string;
    Option2?: string;
    Option3?: string;
    Option4?: string;
    Option5?: string;
    RightAnswer?: string;
    LiveSessionLogId?: number;
    TotalAttempts?: number;
    AverageResponseTime?: number;
    NumberOfCorrect?: number;
    NumberOfWrong?: number;
    BloomsTaxonomyId?: number;
    Weightage?: number;
    IsActive?: boolean;
    BloomsTaxonomyCoginitiveSkill?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class PollRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Question';
    static readonly localTextPrefix = 'LiveSessions.Poll';
    static readonly lookupKey = 'LiveSessions.Poll';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PollRow>('LiveSessions.Poll') }
    static async getLookupAsync() { return getLookupAsync<PollRow>('LiveSessions.Poll') }

    static readonly deletePermission = 'LiveSessions:LiveSessionsManagement:Modify';
    static readonly insertPermission = 'LiveSessions:LiveSessionsManagement:Modify';
    static readonly readPermission = 'LiveSessions:LiveSessionsManagement:View';
    static readonly updatePermission = 'LiveSessions:LiveSessionsManagement:Modify';

    static readonly Fields = fieldsProxy<PollRow>();
}