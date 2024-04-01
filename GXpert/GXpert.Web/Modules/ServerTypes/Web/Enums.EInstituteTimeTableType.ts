import { Decorators } from "@serenity-is/corelib";

export enum EInstituteTimeTableType {
    VIRTUAL = 0,
    FACETOFACE = 1,
    SINGLE_RIGHT_ANSWER = 2
}
Decorators.registerEnumType(EInstituteTimeTableType, 'GXpert.Web.Enums.EInstituteTimeTableType');