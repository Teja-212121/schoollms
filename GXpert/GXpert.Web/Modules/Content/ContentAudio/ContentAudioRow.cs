using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Content;

[ConnectionKey("Default"), Module("Content"), TableName("ContentAudio")]
[DisplayName("Content Audio"), InstanceName("Content Audio")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ContentAudioRow : Row<ContentAudioRow.RowFields>, IIdRow, INameRow
{
    const string jContent = nameof(jContent);
    const string jLanguage = nameof(jLanguage);
    const string jUser = nameof(jUser);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Media File"), Size(1000), NotNull, QuickSearch, NameProperty]
    public string MediaFile { get => fields.MediaFile[this]; set => fields.MediaFile[this] = value; }

    [DisplayName("Hls File"), Size(1000)]
    public string HlsFile { get => fields.HlsFile[this]; set => fields.HlsFile[this] = value; }

    [DisplayName("File Key Url"), Size(1000)]
    public string FileKeyUrl { get => fields.FileKeyUrl[this]; set => fields.FileKeyUrl[this] = value; }

    [DisplayName("Iv"), Column("IV"), Size(500)]
    public string Iv { get => fields.Iv[this]; set => fields.Iv[this] = value; }

    [DisplayName("Content"), NotNull, ForeignKey(typeof(ContentRow)), LeftJoin(jContent), TextualField(nameof(ContentTitle))]
    [LookupEditor(typeof(ContentRow), Async = true)]
    public int? ContentId { get => fields.ContentId[this]; set => fields.ContentId[this] = value; }

    [DisplayName("Language"), NotNull, ForeignKey("ContentLanguages", "Id"), LeftJoin(jLanguage), TextualField(nameof(LanguageName))]
    public int? LanguageId { get => fields.LanguageId[this]; set => fields.LanguageId[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Content Title"), Origin(jContent, nameof(ContentRow.Title))]
    public string ContentTitle { get => fields.ContentTitle[this]; set => fields.ContentTitle[this] = value; }

    [DisplayName("Language Name"), Expression($"{jLanguage}.[Name]")]
    public string LanguageName { get => fields.LanguageName[this]; set => fields.LanguageName[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField MediaFile;
        public StringField HlsFile;
        public StringField FileKeyUrl;
        public StringField Iv;
        public Int32Field ContentId;
        public Int32Field LanguageId;
        public Int32Field UserId;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public Int16Field IsActive;

        public StringField ContentTitle;
        public StringField LanguageName;
        public StringField Username;
    }
}