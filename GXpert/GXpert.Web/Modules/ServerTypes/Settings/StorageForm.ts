import { StringEditor, EnumEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { EStorageType } from "../Web/Enums.EStorageType";

export interface StorageForm {
    AccessKeyId: StringEditor;
    SecretAccessKey: StringEditor;
    Endpoint: StringEditor;
    Region: StringEditor;
    BucketName: StringEditor;
    S3Types: EnumEditor;
    IsDefault: BooleanEditor;
    UrlPreview: StringEditor;
    UploadPath: StringEditor;
}

export class StorageForm extends PrefixedContext {
    static readonly formKey = 'Settings.Storage';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StorageForm.init)  {
            StorageForm.init = true;

            var w0 = StringEditor;
            var w1 = EnumEditor;
            var w2 = BooleanEditor;

            initFormType(StorageForm, [
                'AccessKeyId', w0,
                'SecretAccessKey', w0,
                'Endpoint', w0,
                'Region', w0,
                'BucketName', w0,
                'S3Types', w1,
                'IsDefault', w2,
                'UrlPreview', w0,
                'UploadPath', w0
            ]);
        }
    }
}

[EStorageType]; // referenced types