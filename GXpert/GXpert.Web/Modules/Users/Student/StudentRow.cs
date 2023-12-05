using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Users;

[ConnectionKey("Default"), Module("Users"), TableName("Students")]
[DisplayName("Student"), InstanceName("Student")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class StudentRow : Row<StudentRow.RowFields>, IIdRow, INameRow
{
    const string jUser = nameof(jUser);
    const string jState = nameof(jState);
    const string jDistrict = nameof(jDistrict);
    const string jTaluka = nameof(jTaluka);
    const string jSchool = nameof(jSchool);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Prn"), Column("PRN"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Prn { get => fields.Prn[this]; set => fields.Prn[this] = value; }

    [DisplayName("Name"), Size(500), NotNull]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Email"), Size(500), NotNull]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Mobile"), Size(12), NotNull]
    public string Mobile { get => fields.Mobile[this]; set => fields.Mobile[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Description"), Size(500)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("State"), ForeignKey("States", "Id"), LeftJoin(jState), TextualField(nameof(StateTitle))]
    public int? StateId { get => fields.StateId[this]; set => fields.StateId[this] = value; }

    [DisplayName("District"), ForeignKey("Districts", "Id"), LeftJoin(jDistrict), TextualField(nameof(DistrictTitle))]
    public int? DistrictId { get => fields.DistrictId[this]; set => fields.DistrictId[this] = value; }

    [DisplayName("Taluka"), ForeignKey("Talukas", "Id"), LeftJoin(jTaluka), TextualField(nameof(TalukaTitle))]
    public int? TalukaId { get => fields.TalukaId[this]; set => fields.TalukaId[this] = value; }

    [DisplayName("Dob"), Column("DOB")]
    public DateTime? Dob { get => fields.Dob[this]; set => fields.Dob[this] = value; }

    [DisplayName("School"), ForeignKey("Schools", "Id"), LeftJoin(jSchool), TextualField(nameof(SchoolName))]
    public int? SchoolId { get => fields.SchoolId[this]; set => fields.SchoolId[this] = value; }

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

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    [DisplayName("State Title"), Expression($"{jState}.[Title]")]
    public string StateTitle { get => fields.StateTitle[this]; set => fields.StateTitle[this] = value; }

    [DisplayName("District Title"), Expression($"{jDistrict}.[Title]")]
    public string DistrictTitle { get => fields.DistrictTitle[this]; set => fields.DistrictTitle[this] = value; }

    [DisplayName("Taluka Title"), Expression($"{jTaluka}.[Title]")]
    public string TalukaTitle { get => fields.TalukaTitle[this]; set => fields.TalukaTitle[this] = value; }

    [DisplayName("School Name"), Expression($"{jSchool}.[Name]")]
    public string SchoolName { get => fields.SchoolName[this]; set => fields.SchoolName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Prn;
        public StringField Name;
        public StringField Email;
        public StringField Mobile;
        public Int32Field UserId;
        public StringField Description;
        public Int32Field StateId;
        public Int32Field DistrictId;
        public Int32Field TalukaId;
        public DateTimeField Dob;
        public Int32Field SchoolId;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public BooleanField IsActive;

        public StringField Username;
        public StringField StateTitle;
        public StringField DistrictTitle;
        public StringField TalukaTitle;
        public StringField SchoolName;
    }
}