import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { StorageRow } from "./StorageRow";

export interface StorageColumns {
    Id: Column<StorageRow>;
    AccessKeyId: Column<StorageRow>;
    SecretAccessKey: Column<StorageRow>;
    Endpoint: Column<StorageRow>;
    Region: Column<StorageRow>;
    BucketName: Column<StorageRow>;
    S3Types: Column<StorageRow>;
    IsDefault: Column<StorageRow>;
    UrlPreview: Column<StorageRow>;
    UploadPath: Column<StorageRow>;
}

export class StorageColumns extends ColumnsBase<StorageRow> {
    static readonly columnsKey = 'Settings.Storage';
    static readonly Fields = fieldsProxy<StorageColumns>();
}