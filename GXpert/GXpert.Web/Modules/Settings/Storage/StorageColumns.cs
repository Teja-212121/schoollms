using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Settings.Columns;

[ColumnsScript("Settings.Storage")]
[BasedOnRow(typeof(StorageRow), CheckNames = true)]
public class StorageColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string AccessKeyId { get; set; }
    public string SecretAccessKey { get; set; }
    public string Endpoint { get; set; }
    public string Region { get; set; }
    public string BucketName { get; set; }
    public short S3Types { get; set; }
    public bool IsDefault { get; set; }
    public string UrlPreview { get; set; }
    public string UploadPath { get; set; }
}