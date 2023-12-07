import { Decorators } from "@serenity-is/corelib";

export enum ESchoolTimeTableType {
    VIRTUAL = 0,
    FACETOFACE = 1
}
Decorators.registerEnumType(ESchoolTimeTableType, 'GXpert.Web.Enums.ESchoolTimeTableType');