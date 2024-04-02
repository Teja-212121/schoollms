using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Masters;

[ConnectionKey("Default"), Module("Masters"), TableName("Talukas")]
[DisplayName("Taluka"), InstanceName("Taluka")]
[ReadPermission(PermissionKeys.MastersManagement.View)]
[ModifyPermission(PermissionKeys.MastersManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Masters.Taluka")]
public sealed class TalukaRow : LoggingRow<TalukaRow.RowFields>, IIdRow, INameRow
{
    const string jState = nameof(jState);
    const string jDistrict = nameof(jDistrict);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("State"), NotNull, ForeignKey(typeof(StateRow)), LeftJoin(jState), TextualField(nameof(StateTitle))]
    [ServiceLookupEditor(typeof(StateRow)),LookupInclude]
    public int? StateId { get => fields.StateId[this]; set => fields.StateId[this] = value; }

    [DisplayName("District"), NotNull, ForeignKey(typeof(DistrictRow)), LeftJoin(jDistrict), TextualField(nameof(DistrictTitle))]
    [ServiceLookupEditor(typeof(DistrictRow),CascadeFrom = "StateId",CascadeField = "StateId")]
    public int? DistrictId { get => fields.DistrictId[this]; set => fields.DistrictId[this] = value; }

    [DisplayName("Short Name"), Size(200)]
    public string ShortName { get => fields.ShortName[this]; set => fields.ShortName[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("State Title"), Origin(jState, nameof(StateRow.Title))]
    public string StateTitle { get => fields.StateTitle[this]; set => fields.StateTitle[this] = value; }

    [DisplayName("District Title"), Origin(jDistrict, nameof(DistrictRow.Title))]
    public string DistrictTitle { get => fields.DistrictTitle[this]; set => fields.DistrictTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public Int32Field StateId;
        public Int32Field DistrictId;
        public StringField ShortName;
        public BooleanField IsActive;

        public StringField StateTitle;
        public StringField DistrictTitle;
    }
}