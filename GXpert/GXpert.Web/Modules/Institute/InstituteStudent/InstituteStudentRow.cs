using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Institute;

[ConnectionKey("Default"), Module("Institute"), TableName("InstituteStudents")]
[DisplayName("Institute Student"), InstanceName("Institute Student")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class InstituteStudentRow : LoggingRow<InstituteStudentRow.RowFields>, IIdRow, INameRow
{
    const string jStudent = nameof(jStudent);
    const string jInstitute = nameof(jInstitute);
    const string jClass = nameof(jClass);
    const string jAcademicYear = nameof(jAcademicYear);
    const string jSemester= nameof(jSemester);
    const string jInstituteDivision = nameof(jInstituteDivision);
    

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Student"), NotNull, ForeignKey(typeof(Users.StudentRow)), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor(typeof(Users.StudentRow))]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Institute"), NotNull, ForeignKey("Institutes", "Id"), LeftJoin(jInstitute)]
    [LookupEditor("Institute.Institute")]
    public int? InstituteId { get => fields.InstituteId[this]; set => fields.InstituteId[this] = value; }

    [DisplayName("Class"), ForeignKey(typeof(Syllabus.ClassRow)), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor(typeof(Syllabus.ClassRow))]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }
    [DisplayName("InstituteDivision"), ForeignKey("InstituteDivision", "Id"), LeftJoin(jInstituteDivision)]
    [LookupEditor("Institute.InstituteDivision")]
    public int? InstituteDivisionId { get => fields.InstituteDivisionId[this]; set => fields.InstituteDivisionId[this] = value; }
    [DisplayName("Division") ,Expression($"{jInstituteDivision}.[Division]")]
    public string Division { get => fields.Division[this]; set => fields.Division[this] = value; }


    [DisplayName("Roll Number"), Size(50)]
    public string RollNumber { get => fields.RollNumber[this]; set => fields.RollNumber[this] = value; }

    [DisplayName("Description"), Size(255)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Academic Year"), NotNull, ForeignKey(typeof(Masters.AcademicYearRow)), LeftJoin(jAcademicYear)]
    [TextualField(nameof(AcademicYearName)), LookupEditor(typeof(Masters.AcademicYearRow))]
    public int? AcademicYearId { get => fields.AcademicYearId[this]; set => fields.AcademicYearId[this] = value; }

    [DisplayName("Is Active"), NotNull, DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Student Prn"), Origin(jStudent, nameof(Users.StudentRow.Prn))]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("Institute Name"), Expression($"{jInstitute}.[Name]"),NameProperty]
    public string InstituteName { get => fields.InstituteName[this]; set => fields.InstituteName[this] = value; }

    [DisplayName("Class Title"), Origin(jClass, nameof(Syllabus.ClassRow.Title))]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Academic Year Name"), Origin(jAcademicYear, nameof(Masters.AcademicYearRow.Name))]
    public string AcademicYearName { get => fields.AcademicYearName[this]; set => fields.AcademicYearName[this] = value; }

    [DisplayName("Semester"), ForeignKey("Semester", "Id"), LeftJoin(jSemester)]
        [LookupEditor("Syllabus.Semester")]
    public int? SemesterId { get => fields.SemesterId[this]; set => fields.SemesterId[this] = value; }

    [DisplayName("Semester"), Expression($"{jSemester}.[Title]")]
    public string Semester { get => fields.Semester[this]; set => fields.Semester[this] = value; }

    [DisplayName("Start Date")]
    public DateTime? StartDate { get => fields.StartDate[this]; set => fields.StartDate[this] = value; }

    [DisplayName("End Date")]
    public DateTime? EndDate { get => fields.EndDate[this]; set => fields.EndDate[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field StudentId;
        public Int32Field InstituteId;
        public Int32Field InstituteDivisionId;
        public Int32Field ClassId;
        public StringField Division;
        public StringField RollNumber;
        public StringField Description;
        public Int32Field AcademicYearId;
        public BooleanField IsActive;
        public DateTimeField StartDate;
        public DateTimeField EndDate;
        public StringField StudentPrn;
        public StringField InstituteName;
        public StringField ClassTitle;
        public StringField AcademicYearName;
        public Int32Field SemesterId;
        public StringField Semester;
    }
}