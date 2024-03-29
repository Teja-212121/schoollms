using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Playlist;

[ConnectionKey("Default"), Module("Playlist"), TableName("Modules")]
[DisplayName("Module"), InstanceName("Module")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Playlist.Module")]
public sealed class ModuleRow : LoggingRow<ModuleRow.RowFields>, IIdRow, INameRow
{
    const string jParent = nameof(jParent);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Parent"), ForeignKey(typeof(ModuleRow)), LeftJoin(jParent), TextualField(nameof(ParentTitle))]
    [ServiceLookupEditor(typeof(ModuleRow))]
    public int? ParentId { get => fields.ParentId[this]; set => fields.ParentId[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public float? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Parent Title"), Origin(jParent, nameof(ModuleRow.Title))]
    public string ParentTitle { get => fields.ParentTitle[this]; set => fields.ParentTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public StringField Description;
        public Int32Field ParentId;
        public SingleField SortOrder;
        public BooleanField IsActive;

        public StringField ParentTitle;
    }
}