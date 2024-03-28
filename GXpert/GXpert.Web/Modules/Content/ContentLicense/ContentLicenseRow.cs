using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Content;

[ConnectionKey("Default"), Module("Content"), TableName("ContentLicenses")]
[DisplayName("Content License"), InstanceName("Content License")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ContentLicenseRow : Row<ContentLicenseRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description"), Size(1000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

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

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public Int16Field IsActive;

    }
}