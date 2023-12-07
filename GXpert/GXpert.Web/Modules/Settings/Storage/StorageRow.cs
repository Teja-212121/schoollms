using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Settings;

[ConnectionKey("Default"), Module("Settings"), TableName("Storage")]
[DisplayName("Storage"), InstanceName("Storage")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class StorageRow : LoggingRow<StorageRow.RowFields>, IIdRow, INameRow
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
    public EStorageType? S3Types { get => (EStorageType?)fields.S3Types[this]; set => fields.S3Types[this] = (short?)value; }

    [DisplayName("Is Default")]
    public bool? IsDefault { get => fields.IsDefault[this]; set => fields.IsDefault[this] = value; }

    [DisplayName("Url Preview")]
    public string UrlPreview { get => fields.UrlPreview[this]; set => fields.UrlPreview[this] = value; }

    [DisplayName("Upload Path"), NotNull]
    public string UploadPath { get => fields.UploadPath[this]; set => fields.UploadPath[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField AccessKeyId;
        public StringField SecretAccessKey;
        public StringField Endpoint;
        public StringField Region;
        public StringField BucketName;
        public Int16Field S3Types;
        public BooleanField IsDefault;
        public StringField UrlPreview;
        public StringField UploadPath;
        public BooleanField IsActive;

    }
}