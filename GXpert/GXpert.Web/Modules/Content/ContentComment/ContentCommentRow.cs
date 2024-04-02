using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Content;

[ConnectionKey("Default"), Module("Content"), TableName("ContentComments")]
[DisplayName("Content Comment"), InstanceName("Content Comment")]
[ReadPermission(PermissionKeys.ContentManagement.View)]
[ModifyPermission(PermissionKeys.ContentManagement.View)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Content.ContentComment")]
public sealed class ContentCommentRow : LoggingRow<ContentCommentRow.RowFields>, IIdRow, INameRow
{
    const string jParent = nameof(jParent);
    const string jContent = nameof(jContent);
    const string jUser = nameof(jUser);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Comment Text"), Size(100), NotNull, QuickSearch, NameProperty]
    public string CommentText { get => fields.CommentText[this]; set => fields.CommentText[this] = value; }

    [DisplayName("Comment Left"), NotNull]
    public int? CommentLeft { get => fields.CommentLeft[this]; set => fields.CommentLeft[this] = value; }

    [DisplayName("Comment Right"), NotNull]
    public int? CommentRight { get => fields.CommentRight[this]; set => fields.CommentRight[this] = value; }

    [DisplayName("Tree Id"), NotNull]
    public int? TreeId { get => fields.TreeId[this]; set => fields.TreeId[this] = value; }

    [DisplayName("Comment Level"), NotNull]
    public int? CommentLevel { get => fields.CommentLevel[this]; set => fields.CommentLevel[this] = value; }

    [DisplayName("Parent"), ForeignKey(typeof(ContentCommentRow)), LeftJoin(jParent), TextualField(nameof(ParentCommentText))]
    [ServiceLookupEditor(typeof(ContentCommentRow))]
    public int? ParentId { get => fields.ParentId[this]; set => fields.ParentId[this] = value; }

    [DisplayName("Content"), NotNull, ForeignKey(typeof(ContentRow)), LeftJoin(jContent), TextualField(nameof(ContentTitle))]
    [LookupEditor(typeof(ContentRow), Async = true)]
    public int? ContentId { get => fields.ContentId[this]; set => fields.ContentId[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }


    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Parent Comment Text"), Origin(jParent, nameof(ContentCommentRow.CommentText))]
    public string ParentCommentText { get => fields.ParentCommentText[this]; set => fields.ParentCommentText[this] = value; }

    [DisplayName("Content Title"), Origin(jContent, nameof(ContentRow.Title))]
    public string ContentTitle { get => fields.ContentTitle[this]; set => fields.ContentTitle[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField CommentText;
        public Int32Field CommentLeft;
        public Int32Field CommentRight;
        public Int32Field TreeId;
        public Int32Field CommentLevel;
        public Int32Field ParentId;
        public Int32Field ContentId;
        public Int32Field UserId;
       
        public Int16Field IsActive;

        public StringField ParentCommentText;
        public StringField ContentTitle;
        public StringField Username;
    }
}