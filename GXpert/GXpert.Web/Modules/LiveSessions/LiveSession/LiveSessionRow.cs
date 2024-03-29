using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.LiveSessions;

[ConnectionKey("Default"), Module("LiveSessions"), TableName("LiveSessions")]
[DisplayName("Live Session"), InstanceName("Live Session")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("LiveSessions.LiveSession")]
public sealed class LiveSessionRow : LoggingRow<LiveSessionRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Meeting Id"), Size(2000), NotNull, QuickSearch, NameProperty]
    public string MeetingId { get => fields.MeetingId[this]; set => fields.MeetingId[this] = value; }
    [DisplayName("Title"), Size(255)]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Live Provider"), NotNull]
    public ELiveProvider? LiveProvider { get => (ELiveProvider?)fields.LiveProvider[this]; set => fields.LiveProvider[this] = (short?)value; }

    [DisplayName("Password"), Size(200), NotNull]
    public string Password { get => fields.Password[this]; set => fields.Password[this] = value; }

    [DisplayName("Secret"), Size(200), NotNull]
    public string Secret { get => fields.Secret[this]; set => fields.Secret[this] = value; }

    [DisplayName("Live Additional Info"), Size(2000), NotNull]
    public string LiveAdditionalInfo { get => fields.LiveAdditionalInfo[this]; set => fields.LiveAdditionalInfo[this] = value; }

    [DisplayName("Search Tags"), Size(1000)]
    public string SearchTags { get => fields.SearchTags[this]; set => fields.SearchTags[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField MeetingId;
        public Int16Field LiveProvider;
        public StringField Password;
        public StringField Secret;
        public StringField Title;
        public StringField LiveAdditionalInfo;
        public StringField SearchTags;
        public BooleanField IsActive;

    }
}