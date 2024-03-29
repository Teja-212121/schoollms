using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Content;

[ConnectionKey("Default"), Module("Content"), TableName("ContentSubtitles")]
[DisplayName("Content Subtitle"), InstanceName("Content Subtitle")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Content.ContentSubtitle")]
public sealed class ContentSubtitleRow : LoggingRow<ContentSubtitleRow.RowFields>, IIdRow, INameRow
{
    const string jContent = nameof(jContent);
    const string jLanguage = nameof(jLanguage);
    const string jUser = nameof(jUser);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Subtitle File"), Size(1000), NotNull, QuickSearch, NameProperty,FileUploadEditor]
    public string SubtitleFile { get => fields.SubtitleFile[this]; set => fields.SubtitleFile[this] = value; }

    [DisplayName("Content"), NotNull, ForeignKey(typeof(ContentRow)), LeftJoin(jContent), TextualField(nameof(ContentTitle))]
    [LookupEditor(typeof(ContentRow), Async = true)]
    public int? ContentId { get => fields.ContentId[this]; set => fields.ContentId[this] = value; }

    [DisplayName("Language"), ForeignKey("ContentLanguages", "Id"), LeftJoin(jLanguage), TextualField(nameof(LanguageName))]
    [LookupEditor("Content.ContentLanguage")]
    public int? LanguageId { get => fields.LanguageId[this]; set => fields.LanguageId[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Content Title"), Origin(jContent, nameof(ContentRow.Title))]
    public string ContentTitle { get => fields.ContentTitle[this]; set => fields.ContentTitle[this] = value; }

    [DisplayName("Language Name"), Expression($"{jLanguage}.[Name]")]
    public string LanguageName { get => fields.LanguageName[this]; set => fields.LanguageName[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField SubtitleFile;
        public Int32Field ContentId;
        public Int32Field LanguageId;
        public Int32Field UserId;
       
        public Int16Field IsActive;

        public StringField ContentTitle;
        public StringField LanguageName;
        public StringField Username;
    }
}