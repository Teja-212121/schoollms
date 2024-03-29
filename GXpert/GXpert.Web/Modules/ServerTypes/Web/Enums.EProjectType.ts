import { Decorators } from "@serenity-is/corelib";

export enum EProjectType {
    Individual = 0,
    Group = 1
}
Decorators.registerEnumType(EProjectType, 'GXpert.Web.Enums.EProjectType');