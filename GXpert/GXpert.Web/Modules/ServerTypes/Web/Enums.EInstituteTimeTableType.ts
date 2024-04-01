import { Decorators } from "@serenity-is/corelib";

export enum EInstituteTimeTableType {
    VIRTUAL = 0,
    FACETOFACE = 1,
    SINGLE_RIGHT_ANSWER = 2,
    TRUE_OR_FALSE = 3,
    NUMERICAL = 4,
    MULTIPLE_RIGHT_ANSWER = 5
}
Decorators.registerEnumType(EInstituteTimeTableType, 'GXpert.Web.Enums.EInstituteTimeTableType');