using GXpert.Masters;
using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Users;

[ConnectionKey("Default"), Module("Users"), TableName("Students")]
[DisplayName("Student"), InstanceName("Student")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Users.Student")]
public sealed class StudentRow : LoggingRow<StudentRow.RowFields>, IIdRow, INameRow
{
    const string jUser = nameof(jUser);
    const string jState = nameof(jState);
    const string jDistrict = nameof(jDistrict);
    const string jDepartment = nameof(jDepartment);
    const string jTaluka = nameof(jTaluka);
    const string jBranch = nameof(jBranch);
    const string jCourse = nameof(jCourse);
    const string jInstitute = nameof(jInstitute);
    const string jInstituteDivision = nameof(jInstituteDivision);

    const string jClass = nameof(jClass);
    const string jSemester = nameof(jSemester);
    const string jAcademicYear = nameof(jAcademicYear);


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
    [LookupEditor("Administration.User")]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }


    [DisplayName("Institute"), NotNull, ForeignKey("Institutes", "Id"), LeftJoin(jInstitute)]
    [LookupEditor("Institute.Institute")]
    public int? InstituteId { get => fields.InstituteId[this]; set => fields.InstituteId[this] = value; }
    [DisplayName("Department"), ForeignKey("Departments", "Id"), LeftJoin(jDepartment), TextualField(nameof(DepartmentTitle))]
    [LookupEditor("Institute.Department")]
    public int? DepartmentId { get => fields.DepartmentId[this]; set => fields.DepartmentId[this] = value; }
    [DisplayName("Department Title"), Expression($"{jDepartment}.[Title]")]
    public string DepartmentTitle { get => fields.DepartmentTitle[this]; set => fields.DepartmentTitle[this] = value; }
    [DisplayName("Branch"), ForeignKey("Branch", "Id"), LeftJoin(jBranch), TextualField(nameof(BranchTitle))]
    [LookupEditor("Institute.Branch")]
    public int? BranchId { get => fields.BranchId[this]; set => fields.BranchId[this] = value; }
    [DisplayName("Branch Title"), Expression($"{jBranch}.[Title]")]
    public string BranchTitle { get => fields.BranchTitle[this]; set => fields.BranchTitle[this] = value; }
    [DisplayName("InstituteDivision"), ForeignKey("InstituteDivision", "Id"), LeftJoin(jInstituteDivision)]
    [LookupEditor("Institute.InstituteDivision")]
    public int? DivisionId { get => fields.DivisionId[this]; set => fields.DivisionId[this] = value; }
    [DisplayName("InstituteDivision"), Expression($"{jInstituteDivision}.[Division]")]
    public string InstituteDivision { get => fields.InstituteDivision[this]; set => fields.InstituteDivision[this] = value; }
    [DisplayName("Course"), NotNull, ForeignKey(typeof(Syllabus.CourseRow)), LeftJoin(jCourse), TextualField(nameof(CourseTitle))]
    [ServiceLookupEditor(typeof(Syllabus.CourseRow), Service = "Syllabus/Course/List")]
    public int? CourseId { get => fields.CourseId[this]; set => fields.CourseId[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey(typeof(Syllabus.ClassRow)), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor(typeof(Syllabus.ClassRow))]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Semester"), NotNull, ForeignKey(typeof(Syllabus.SemesterRow)), LeftJoin(jSemester), TextualField(nameof(SemesterTitle))]
    [ServiceLookupEditor(typeof(Syllabus.SemesterRow), Service = "Syllabus/Semester/List")]
    public int? SemesterId { get => fields.SemesterId[this]; set => fields.SemesterId[this] = value; }
    [DisplayName("Current Academic Year"), NotNull, ForeignKey(typeof(AcademicYearRow)), LeftJoin(jAcademicYear)]
    [TextualField(nameof(AcademicYearName)), LookupEditor(typeof(AcademicYearRow))]
    public int? CurrentAcademicYearId { get => fields.CurrentAcademicYearId[this]; set => fields.CurrentAcademicYearId[this] = value; }
    [DisplayName("Institute Name"), Expression($"{jInstitute}.[Name]")]
    public string InstituteName { get => fields.InstituteName[this]; set => fields.InstituteName[this] = value; }
    [DisplayName("Course Title"), Origin(jCourse, nameof(Syllabus.CourseRow.Title))]
    public string CourseTitle { get => fields.CourseTitle[this]; set => fields.CourseTitle[this] = value; }

    [DisplayName("Class Title"), Origin(jClass, nameof(Syllabus.ClassRow.Title))]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Semester Title"), Origin(jSemester, nameof(Syllabus.SemesterRow.Title))]
    public string SemesterTitle { get => fields.SemesterTitle[this]; set => fields.SemesterTitle[this] = value; }

    [DisplayName("Academic Year Name"), Origin(jAcademicYear, nameof(AcademicYearRow.Name))]
    public string AcademicYearName { get => fields.AcademicYearName[this]; set => fields.AcademicYearName[this] = value; }

    [DisplayName("Gender"), Size(500)]
    public EGender? Gender { get => (EGender)fields.Gender[this]; set => fields.Gender[this] = (short?)value; }
    [DisplayName("AddressLine1"), Size(1000)]
    public string AddressLine1 { get => fields.AddressLine1[this]; set => fields.AddressLine1[this] = value; }
    [DisplayName("AddressLine2"), Size(500)]
    public string AddressLine2 { get => fields.AddressLine2[this]; set => fields.AddressLine2[this] = value; }
    [DisplayName("Description"), Size(500)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("State"), ForeignKey("States", "Id"), LeftJoin(jState), TextualField(nameof(StateTitle))]
    [LookupEditor("Masters.State")]
    public int? StateId { get => fields.StateId[this]; set => fields.StateId[this] = value; }

    [DisplayName("District"), ForeignKey("Districts", "Id"), LeftJoin(jDistrict), TextualField(nameof(DistrictTitle))]
    [LookupEditor("Masters.District")]
    public int? DistrictId { get => fields.DistrictId[this]; set => fields.DistrictId[this] = value; }

    [DisplayName("Taluka"), ForeignKey("Talukas", "Id"), LeftJoin(jTaluka), TextualField(nameof(TalukaTitle))]
    [LookupEditor("Masters.Taluka")]
    public int? TalukaId { get => fields.TalukaId[this]; set => fields.TalukaId[this] = value; }

    [DisplayName("Dob"), Column("DOB")]
    public DateTime? Dob { get => fields.Dob[this]; set => fields.Dob[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    [DisplayName("State Title"), Expression($"{jState}.[Title]")]
    public string StateTitle { get => fields.StateTitle[this]; set => fields.StateTitle[this] = value; }

    [DisplayName("District Title"), Expression($"{jDistrict}.[Title]")]
    public string DistrictTitle { get => fields.DistrictTitle[this]; set => fields.DistrictTitle[this] = value; }

    [DisplayName("Taluka Title"), Expression($"{jTaluka}.[Title]")]
    public string TalukaTitle { get => fields.TalukaTitle[this]; set => fields.TalukaTitle[this] = value; }


    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Prn;
        public StringField Name;
        public StringField Email;
        public StringField Mobile;
        public Int32Field UserId;
        public Int32Field InstituteId;
        public Int32Field DepartmentId;
        public Int32Field BranchId;
        public Int32Field CourseId;
        public Int32Field ClassId;
        public Int32Field SemesterId;
        public Int32Field CurrentAcademicYearId;
        public StringField InstituteName;
        public Int32Field DivisionId;
        public StringField InstituteDivision;
        public StringField CourseTitle;
        public StringField ClassTitle;
        public Int16Field Gender;
        public StringField AddressLine1;
        public StringField AddressLine2;
        public StringField SemesterTitle;
        public StringField AcademicYearName;
        public StringField Description;
        public Int32Field StateId;
        public Int32Field DistrictId;
        public Int32Field TalukaId;
        public DateTimeField Dob;
        public StringField DepartmentTitle;
        public StringField BranchTitle;
        public BooleanField IsActive;

        public StringField Username;
        public StringField StateTitle;
        public StringField DistrictTitle;
        public StringField TalukaTitle;
        
    }
}