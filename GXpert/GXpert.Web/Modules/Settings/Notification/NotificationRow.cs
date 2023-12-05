using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Settings;

[ConnectionKey("Default"), Module("Settings"), TableName("Notifications")]
[DisplayName("Notification"), InstanceName("Notification"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class NotificationRow : Row<NotificationRow.RowFields>, IIdRow, INameRow
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