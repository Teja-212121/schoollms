using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Masters;

[ConnectionKey("Default"), Module("Masters"), TableName("BloomsTaxanomy")]
[DisplayName("Blooms Taxanomy"), InstanceName("Blooms Taxanomy")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Masters.BloomsTaxanomy")]
public sealed class BloomsTaxanomyRow : LoggingRow<BloomsTaxanomyRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Coginitive Skill"), Size(255), NotNull, QuickSearch, NameProperty]
    public string CoginitiveSkill { get => fields.CoginitiveSkill[this]; set => fields.CoginitiveSkill[this] = value; }

    [DisplayName("Sort Order")]
    public int? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField CoginitiveSkill;
        public Int32Field SortOrder;
        public BooleanField IsActive;

    }
}