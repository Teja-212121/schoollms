using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Settings;

[ConnectionKey("Default"), Module("Settings"), TableName("Notifications")]
[DisplayName("Notification"), InstanceName("Notification")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class NotificationRow : LoggingRow<NotificationRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Notification Guid")]
    public Guid? NotificationGuid { get => fields.NotificationGuid[this]; set => fields.NotificationGuid[this] = value; }

    [DisplayName("Message"), NotNull, QuickSearch, NameProperty]
    public string Message { get => fields.Message[this]; set => fields.Message[this] = value; }

    [DisplayName("Title"), NotNull]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Created On Utc"), NotNull]
    public DateTime? CreatedOnUtc { get => fields.CreatedOnUtc[this]; set => fields.CreatedOnUtc[this] = value; }

    [DisplayName("Sent Tries")]
    public int? SentTries { get => fields.SentTries[this]; set => fields.SentTries[this] = value; }

    [DisplayName("Sent On Utc")]
    public DateTime? SentOnUtc { get => fields.SentOnUtc[this]; set => fields.SentOnUtc[this] = value; }

    [DisplayName("Has Error")]
    public bool? HasError { get => fields.HasError[this]; set => fields.HasError[this] = value; }

    [DisplayName("Result"), Size(1000)]
    public string Result { get => fields.Result[this]; set => fields.Result[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public GuidField NotificationGuid;
        public StringField Message;
        public StringField Title;
        public DateTimeField CreatedOnUtc;
        public Int32Field SentTries;
        public DateTimeField SentOnUtc;
        public BooleanField HasError;
        public StringField Result;
        public BooleanField IsActive;

    }
}