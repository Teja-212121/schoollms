using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Content;

[ConnectionKey("Default"), Module("Content"), TableName("ContentMediaRatings")]
[DisplayName("Content Media Rating"), InstanceName("Content Media Rating")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ContentMediaRatingRow : Row<ContentMediaRatingRow.RowFields>, IIdRow
{
    const string jContent = nameof(jContent);
    const string jRating = nameof(jRating);
    const string jUser = nameof(jUser);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Content"), NotNull, ForeignKey(typeof(ContentRow)), LeftJoin(jContent), TextualField(nameof(ContentTitle))]
    [LookupEditor(typeof(ContentRow), Async = true)]
    public int? ContentId { get => fields.ContentId[this]; set => fields.ContentId[this] = value; }

    [DisplayName("Rating"), NotNull, ForeignKey("ContentRatings", "Id"), LeftJoin(jRating), TextualField(nameof(RatingName))]
    public int? RatingId { get => fields.RatingId[this]; set => fields.RatingId[this] = value; }

    [DisplayName("Score"), NotNull]
    public short? Score { get => fields.Score[this]; set => fields.Score[this] = value; }

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

    [DisplayName("Rating Name"), Expression($"{jRating}.[Name]")]
    public string RatingName { get => fields.RatingName[this]; set => fields.RatingName[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field ContentId;
        public Int32Field RatingId;
        public Int16Field Score;
        public Int32Field UserId;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public Int16Field IsActive;

        public StringField ContentTitle;
        public StringField RatingName;
        public StringField Username;
    }
}