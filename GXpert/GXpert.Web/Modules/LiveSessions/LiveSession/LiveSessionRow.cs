using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.LiveSessions;

[ConnectionKey("Default"), Module("LiveSessions"), TableName("LiveSessions")]
[DisplayName("Live Session"), InstanceName("Live Session"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class LiveSessionRow : Row<LiveSessionRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Meeting Id"), Size(2000), NotNull, QuickSearch, NameProperty]
    public string MeetingId { get => fields.MeetingId[this]; set => fields.MeetingId[this] = value; }

    [DisplayName("Live Provider"), NotNull]
    public short? LiveProvider { get => fields.LiveProvider[this]; set => fields.LiveProvider[this] = value; }

    [DisplayName("Password"), Size(200), NotNull]
    public string Password { get => fields.Password[this]; set => fields.Password[this] = value; }

    [DisplayName("Secret"), Size(200), NotNull]
    public string Secret { get => fields.Secret[this]; set => fields.Secret[this] = value; }

    [DisplayName("Live Additional Info"), Size(2000), NotNull]
    public string LiveAdditionalInfo { get => fields.LiveAdditionalInfo[this]; set => fields.LiveAdditionalInfo[this] = value; }

    [DisplayName("Search Tags"), Size(1000)]
    public string SearchTags { get => fields.SearchTags[this]; set => fields.SearchTags[this] = value; }

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