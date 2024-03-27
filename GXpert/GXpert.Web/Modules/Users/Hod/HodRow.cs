using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Users;

[ConnectionKey("Default"), Module("Users"), TableName("Hod")]
[DisplayName("HOD"), InstanceName("Hod")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Users.Hod")]
public sealed class HodRow : LoggingRow<HodRow.RowFields>, IIdRow, INameRow
{
    const string jUser = nameof(jUser);
    const string jState = nameof(jState);
    const string jDistrict = nameof(jDistrict);
    const string jTaluka = nameof(jTaluka);
    const string jInstitute = nameof(jInstitute);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Email"), Size(500), NotNull]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Mobile"), Size(12), NotNull]
    public string Mobile { get => fields.Mobile[this]; set => fields.Mobile[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow))]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("State"), ForeignKey(typeof(Masters.StateRow)), LeftJoin(jState), TextualField(nameof(StateTitle))]
    [LookupEditor(typeof(Masters.StateRow))]
    public int? StateId { get => fields.StateId[this]; set => fields.StateId[this] = value; }

    [DisplayName("District"), ForeignKey(typeof(Masters.DistrictRow)), LeftJoin(jDistrict), TextualField(nameof(DistrictTitle))]
    [LookupEditor(typeof(Masters.DistrictRow))]
    public int? DistrictId { get => fields.DistrictId[this]; set => fields.DistrictId[this] = value; }

    [DisplayName("Taluka"), ForeignKey(typeof(Masters.TalukaRow)), LeftJoin(jTaluka), TextualField(nameof(TalukaTitle))]
    [LookupEditor(typeof(Masters.TalukaRow))]
    public int? TalukaId { get => fields.TalukaId[this]; set => fields.TalukaId[this] = value; }

    [DisplayName("Dob"), Column("DOB")]
    public DateTime? Dob { get => fields.Dob[this]; set => fields.Dob[this] = value; }

    [DisplayName("Institute"), ForeignKey(typeof(Institute.InstituteRow)), LeftJoin(jInstitute), TextualField(nameof(InstituteName))]
    [ServiceLookupEditor(typeof(Institute.InstituteRow), Service = "Institute/Institute/List")]
    public int? InstituteId { get => fields.InstituteId[this]; set => fields.InstituteId[this] = value; }

    
    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    [DisplayName("State Title"), Origin(jState, nameof(Masters.StateRow.Title))]
    public string StateTitle { get => fields.StateTitle[this]; set => fields.StateTitle[this] = value; }

    [DisplayName("District Title"), Origin(jDistrict, nameof(Masters.DistrictRow.Title))]
    public string DistrictTitle { get => fields.DistrictTitle[this]; set => fields.DistrictTitle[this] = value; }

    [DisplayName("Taluka Title"), Origin(jTaluka, nameof(Masters.TalukaRow.Title))]
    public string TalukaTitle { get => fields.TalukaTitle[this]; set => fields.TalukaTitle[this] = value; }

    [DisplayName("Institute Name"), Origin(jInstitute, nameof(Institute.InstituteRow.Name))]
    public string InstituteName { get => fields.InstituteName[this]; set => fields.InstituteName[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Email;
        public StringField Mobile;
        public Int32Field UserId;
        public Int32Field StateId;
        public Int32Field DistrictId;
        public Int32Field TalukaId;
        public DateTimeField Dob;
        public Int32Field InstituteId;
      
        public BooleanField IsActive;

        public StringField Username;
        public StringField StateTitle;
        public StringField DistrictTitle;
        public StringField TalukaTitle;
        public StringField InstituteName;
    }
}