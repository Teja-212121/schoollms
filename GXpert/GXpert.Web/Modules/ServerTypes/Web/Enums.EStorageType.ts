import { Decorators } from "@serenity-is/corelib";

export enum EStorageType {
    AWS_S3 = 0,
    DIGITALOCEAN = 1,
    IDRIVE = 2
}
Decorators.registerEnumType(EStorageType, 'GXpert.Web.Enums.EStorageType');