using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Institute;

[ConnectionKey("Default"), Module("Institute"), TableName("Institutes")]
[DisplayName("Institute"), InstanceName("Institute")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class InstituteRow : Row<InstituteRow.RowFields>, IIdRow, INameRow
{
    const string jState = nameof(jState);
    const string jDistrict = nameof(jDistrict);
    const string jTaluka = nameof(jTaluka);
    const string jPrincipal = nameof(jPrincipal);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description"), Size(1000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("E Type"), Column("eType")]
    public short? EType { get => fields.EType[this]; set => fields.EType[this] = value; }

    [DisplayName("Address"), Size(1000), NotNull]
    public string Address { get => fields.Address[this]; set => fields.Address[this] = value; }

    [DisplayName("City"), Size(200), NotNull]
    public string City { get => fields.City[this]; set => fields.City[this] = value; }

    [DisplayName("State"), NotNull, ForeignKey(typeof(Masters.StateRow)), LeftJoin(jState), TextualField(nameof(StateTitle))]
    [LookupEditor(typeof(Masters.StateRow), Async = true)]
    public int? StateId { get => fields.StateId[this]; set => fields.StateId[this] = value; }

    [DisplayName("District"), NotNull, ForeignKey(typeof(Masters.DistrictRow)), LeftJoin(jDistrict), TextualField(nameof(DistrictTitle))]
    [LookupEditor(typeof(Masters.DistrictRow), Async = true)]
    public int? DistrictId { get => fields.DistrictId[this]; set => fields.DistrictId[this] = value; }

    [DisplayName("Taluka"), NotNull, ForeignKey(typeof(Masters.TalukaRow)), LeftJoin(jTaluka), TextualField(nameof(TalukaTitle))]
    [LookupEditor(typeof(Masters.TalukaRow), Async = true)]
    public int? TalukaId { get => fields.TalukaId[this]; set => fields.TalukaId[this] = value; }

    [DisplayName("Location Info"), Size(2000)]
    public string LocationInfo { get => fields.LocationInfo[this]; set => fields.LocationInfo[this] = value; }

    [DisplayName("Establishment Date")]
    public DateTime? EstablishmentDate { get => fields.EstablishmentDate[this]; set => fields.EstablishmentDate[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Principal"), ForeignKey("Principal", "Id"), LeftJoin(jPrincipal), TextualField(nameof(PrincipalName))]
    public int? PrincipalId { get => fields.PrincipalId[this]; set => fields.PrincipalId[this] = value; }

    [DisplayName("State Title"), Origin(jState, nameof(Masters.StateRow.Title))]
    public string StateTitle { get => fields.StateTitle[this]; set => fields.StateTitle[this] = value; }

    [DisplayName("District Title"), Origin(jDistrict, nameof(Masters.DistrictRow.Title))]
    public string DistrictTitle { get => fields.DistrictTitle[this]; set => fields.DistrictTitle[this] = value; }

    [DisplayName("Taluka Title"), Origin(jTaluka, nameof(Masters.TalukaRow.Title))]
    public string TalukaTitle { get => fields.TalukaTitle[this]; set => fields.TalukaTitle[this] = value; }

    [DisplayName("Principal Name"), Expression($"{jPrincipal}.[Name]")]
    public string PrincipalName { get => fields.PrincipalName[this]; set => fields.PrincipalName[this] = value; }

    public class RowFields : RowFieldsBase
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
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public BooleanField IsActive;
        public Int32Field PrincipalId;

        public StringField StateTitle;
        public StringField DistrictTitle;
        public StringField TalukaTitle;
        public StringField PrincipalName;
    }
}