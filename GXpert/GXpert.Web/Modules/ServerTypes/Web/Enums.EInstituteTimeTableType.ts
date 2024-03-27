import { Decorators } from "@serenity-is/corelib";

export enum EInstituteTimeTableType {
    VIRTUAL = 0,
    FACETOFACE = 1
}
Decorators.registerEnumType(EInstituteTimeTableType, 'GXpert.Web.Enums.EInstituteTimeTableType');