using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Activation;

[ConnectionKey("Default"), Module("Activation"), TableName("SerialKeys")]
[DisplayName("Serial Key"), InstanceName("Serial Key"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class SerialKeyRow : Row<SerialKeyRow.RowFields>, IIdRow, INameRow
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

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }
}