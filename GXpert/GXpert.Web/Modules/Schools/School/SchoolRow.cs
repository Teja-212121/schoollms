using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Schools;

[ConnectionKey("Default"), Module("Schools"), TableName("Schools")]
[DisplayName("School"), InstanceName("School")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Schools.School")]
public sealed class SchoolRow : LoggingRow<SchoolRow.RowFields>, IIdRow, INameRow
{
    const string jState = nameof(jState);
    const string jDistrict = nameof(jDistrict);
    const string jTaluka = nameof(jTaluka);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description"), Size(1000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("E Type"), Column("eType"), Size(200)]
    public ESchoolType? EType { get => (ESchoolType?)fields.EType[this]; set => fields.EType[this] = (short?)value; }

    [DisplayName("Address"), Size(1000), NotNull]
    public string Address { get => fields.Address[this]; set => fields.Address[this] = value; }

    [DisplayName("City"), Size(200), NotNull]
    public string City { get => fields.City[this]; set => fields.City[this] = value; }

    [DisplayName("State"), NotNull, ForeignKey("States", "Id"), LeftJoin(jState), TextualField(nameof(StateTitle))]
    [LookupEditor("Masters.State")]
    public int? StateId { get => fields.StateId[this]; set => fields.StateId[this] = value; }

    [DisplayName("District"), NotNull, ForeignKey("Districts", "Id"), LeftJoin(jDistrict), TextualField(nameof(DistrictTitle))]
    [LookupEditor("Masters.District")]
    public int? DistrictId { get => fields.DistrictId[this]; set => fields.DistrictId[this] = value; }

    [DisplayName("Taluka"), NotNull, ForeignKey("Talukas", "Id"), LeftJoin(jTaluka), TextualField(nameof(TalukaTitle))]
    [LookupEditor("Masters.Taluka")]
    public int? TalukaId { get => fields.TalukaId[this]; set => fields.TalukaId[this] = value; }

    [DisplayName("Location Info"), Size(2000)]
    public string LocationInfo { get => fields.LocationInfo[this]; set => fields.LocationInfo[this] = value; }

    [DisplayName("Establishment Date")]
    public DateTime? EstablishmentDate { get => fields.EstablishmentDate[this]; set => fields.EstablishmentDate[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("State Title"), Expression($"{jState}.[Title]")]
    public string StateTitle { get => fields.StateTitle[this]; set => fields.StateTitle[this] = value; }

    [DisplayName("District Title"), Expression($"{jDistrict}.[Title]")]
    public string DistrictTitle { get => fields.DistrictTitle[this]; set => fields.DistrictTitle[this] = value; }

    [DisplayName("Taluka Title"), Expression($"{jTaluka}.[Title]")]
    public string TalukaTitle { get => fields.TalukaTitle[this]; set => fields.TalukaTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public Int16Field EType;
        public StringField Address;
        public StringField City;
        public Int32Field StateId;
        public Int32Field DistrictId;
        public Int32Field TalukaId;
        public StringField LocationInfo;
        public DateTimeField EstablishmentDate;
        public BooleanField IsActive;

        public StringField StateTitle;
        public StringField DistrictTitle;
        public StringField TalukaTitle;
    }
}