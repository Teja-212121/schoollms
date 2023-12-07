import { Decorators } from "@serenity-is/corelib";

export enum EExamState {
    Draft = 0,
    Published = 1,
    Unpublished = 2
}
Decorators.registerEnumType(EExamState, 'GXpert.Web.Enums.EExamState', 'Workspace.EExamState');