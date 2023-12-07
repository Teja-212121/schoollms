import { Decorators } from "@serenity-is/corelib";

export enum EExamTypes {
    OBJECTIVE = 0,
    SUBJECTIVE = 1,
    HYBRID = 2
}
Decorators.registerEnumType(EExamTypes, 'GXpert.Web.Enums.EExamTypes', 'Workspace.EExamTypes');