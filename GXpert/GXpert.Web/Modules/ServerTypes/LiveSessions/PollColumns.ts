﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EQuestionType } from "../Web/Enums.EQuestionType";
import { PollRow } from "./PollRow";

export interface PollColumns {
    Id: Column<PollRow>;
    Question: Column<PollRow>;
    EQuestionType: Column<PollRow>;
    Option1: Column<PollRow>;
    Option2: Column<PollRow>;
    Option3: Column<PollRow>;
    Option4: Column<PollRow>;
    Option5: Column<PollRow>;
    RightAnswer: Column<PollRow>;
    LiveSessionLogId: Column<PollRow>;
    TotalAttempts: Column<PollRow>;
    AverageResponseTime: Column<PollRow>;
    NumberOfCorrect: Column<PollRow>;
    NumberOfWrong: Column<PollRow>;
    BloomsTaxonomyCoginitiveSkill: Column<PollRow>;
    Weightage: Column<PollRow>;
}

export class PollColumns extends ColumnsBase<PollRow> {
    static readonly columnsKey = 'LiveSessions.Poll';
    static readonly Fields = fieldsProxy<PollColumns>();
}

[EQuestionType]; // referenced types