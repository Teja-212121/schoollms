import { StringEditor, IntegerEditor, BooleanEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface StorageForm {
    AccessKeyId: StringEditor;
    SecretAccessKey: StringEditor;
    Endpoint: StringEditor;
    Region: StringEditor;
    BucketName: StringEditor;
    S3Types: IntegerEditor;
    IsDefault: BooleanEditor;
    UrlPreview: StringEditor;
    UploadPath: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class StorageForm extends PrefixedContext {
    static readonly formKey = 'Settings.Storage';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StorageForm.init)  {
            StorageForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = BooleanEditor;
            var w3 = DateEditor;

            initFormType(StorageForm, [
                'AccessKeyId', w0,
                'SecretAccessKey', w0,
                'Endpoint', w0,
                'Region', w0,
                'BucketName', w0,
                'S3Types', w1,
                'IsDefault', w2,
                'UrlPreview', w0,
                'UploadPath', w0,
                'InsertDate', w3,
                'InsertUserId', w1,
                'UpdateDate', w3,
                'UpdateUserId', w1,
                'IsActive', w2
            ]);
        }
    }
}