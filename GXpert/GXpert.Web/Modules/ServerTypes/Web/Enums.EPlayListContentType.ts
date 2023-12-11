import { Decorators } from "@serenity-is/corelib";

export enum EPlayListContentType {
    PLAYLIST = 0,
    CONTENT = 1,
    EXAM = 2,
    LIVESESSION = 3,
    ASSIGNMENT = 4
}
Decorators.registerEnumType(EPlayListContentType, 'GXpert.Web.Enums.EPlayListContentType');