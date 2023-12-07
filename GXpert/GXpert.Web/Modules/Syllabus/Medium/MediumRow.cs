using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Syllabus;

[ConnectionKey("Default"), Module("Syllabus"), TableName("Mediums")]
[DisplayName("Medium"), InstanceName("Medium")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Syllabus.Medium")]
public sealed class MediumRow : LoggingRow<MediumRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty, LookupInclude]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(2000), NotNull]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public StringField Description;
        public BooleanField IsActive;

    }
}