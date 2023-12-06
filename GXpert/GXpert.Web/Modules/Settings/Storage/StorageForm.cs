using Serenity.ComponentModel;
using System;

namespace GXpert.Settings.Forms;

[FormScript("Settings.Storage")]
[BasedOnRow(typeof(StorageRow), CheckNames = true)]
public class StorageForm
{
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