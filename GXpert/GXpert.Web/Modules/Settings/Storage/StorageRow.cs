using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Settings;

[ConnectionKey("Default"), Module("Settings"), TableName("Storage")]
[DisplayName("Storage"), InstanceName("Storage"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class StorageRow : Row<StorageRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Access Key Id"), Size(1000), NotNull, QuickSearch, NameProperty]
    public string AccessKeyId { get => fields.AccessKeyId[this]; set => fields.AccessKeyId[this] = value; }

    [DisplayName("Secret Access Key"), Size(500), NotNull]
    public string SecretAccessKey { get => fields.SecretAccessKey[this]; set => fields.SecretAccessKey[this] = value; }

    [DisplayName("Endpoint"), Size(1000), NotNull]
    public string Endpoint { get => fields.Endpoint[this]; set => fields.Endpoint[this] = value; }

    [DisplayName("Region"), Size(100), NotNull]
    public string Region { get => fields.Region[this]; set => fields.Region[this] = value; }

    [DisplayName("Bucket Name"), Size(100), NotNull]
    public string BucketName { get => fields.BucketName[this]; set => fields.BucketName[this] = value; }

    [DisplayName("S3 Types"), NotNull]
    public short? S3Types { get => fields.S3Types[this]; set => fields.S3Types[this] = value; }

    [DisplayName("Is Default")]
    public bool? IsDefault { get => fields.IsDefault[this]; set => fields.IsDefault[this] = value; }

    [DisplayName("Url Preview")]
    public string UrlPreview { get => fields.UrlPreview[this]; set => fields.UrlPreview[this] = value; }

    [DisplayName("Upload Path"), NotNull]
    public string UploadPath { get => fields.UploadPath[this]; set => fields.UploadPath[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }
}