using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Activation;

[ConnectionKey("Default"), Module("Activation"), TableName("SerialKeys")]
[DisplayName("Serial Key"), InstanceName("Serial Key")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Activation.SerialKey")]
public sealed class SerialKeyRow : LoggingRow<SerialKeyRow.RowFields>, IIdRow, INameRow
{
    const string jPlayList = nameof(jPlayList);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Serial Key"), Size(100), NotNull, QuickSearch, NameProperty]
    public string SerialKey { get => fields.SerialKey[this]; set => fields.SerialKey[this] = value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Validity Type")]
    public short? ValidityType { get => fields.ValidityType[this]; set => fields.ValidityType[this] = value; }

    [DisplayName("Validity In Days")]
    public short? ValidityInDays { get => fields.ValidityInDays[this]; set => fields.ValidityInDays[this] = value; }

    [DisplayName("Valid Date")]
    public DateTime? ValidDate { get => fields.ValidDate[this]; set => fields.ValidDate[this] = value; }

    [DisplayName("Note"), Size(1000)]
    public string Note { get => fields.Note[this]; set => fields.Note[this] = value; }

    [DisplayName("E Status"), Column("eStatus")]
    public short? EStatus { get => fields.EStatus[this]; set => fields.EStatus[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField SerialKey;
        public Int32Field PlayListId;
        public Int16Field ValidityType;
        public Int16Field ValidityInDays;
        public DateTimeField ValidDate;
        public StringField Note;
        public Int16Field EStatus;
        public Int16Field IsActive;

        public StringField PlayListTitle;
    }
}