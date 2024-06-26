﻿import { fieldsProxy } from "@serenity-is/corelib";
import { EStorageType } from "../Web/Enums.EStorageType";

export interface StorageRow {
    Id?: number;
    AccessKeyId?: string;
    SecretAccessKey?: string;
    Endpoint?: string;
    Region?: string;
    BucketName?: string;
    S3Types?: EStorageType;
    IsDefault?: boolean;
    UrlPreview?: string;
    UploadPath?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class StorageRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'AccessKeyId';
    static readonly localTextPrefix = 'Settings.Storage';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<StorageRow>();
}