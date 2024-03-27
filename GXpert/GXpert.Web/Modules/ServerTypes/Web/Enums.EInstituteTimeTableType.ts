import { Decorators } from "@serenity-is/corelib";

export enum EInstituteTimeTableType {
    VIRTUAL = 0,
    FACETOFACE = 1,
    SINGLE_RIGHT_ANSWER = 2,
    MULTIPLE_RIGHT_ANSWER = 3,
    TRUE_OR_FALSE = 4,
    NUMERICAL = 5
}
Decorators.registerEnumType(EInstituteTimeTableType, 'GXpert.Web.Enums.EInstituteTimeTableType');