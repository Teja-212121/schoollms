using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Institute;

[ConnectionKey("Default"), Module("Institute"), TableName("InstituteTeachers")]
[DisplayName("Institute Teacher"), InstanceName("Institute Teacher")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class InstituteTeacherRow : LoggingRow<InstituteTeacherRow.RowFields>, IIdRow, INameRow
{
    const string jTeacher = nameof(jTeacher);
    const string jSchool = nameof(jSchool);
    const string jClass = nameof(jClass);
    const string jSubject = nameof(jSubject);
    const string jAcademicYear = nameof(jAcademicYear);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Teacher"), NotNull, ForeignKey(typeof(Users.TeacherRow)), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor(typeof(Users.TeacherRow), Async = true)]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("School"), NotNull, ForeignKey("Institutes", "Id"), LeftJoin(jSchool), TextualField(nameof(SchoolName))]
    public int? SchoolId { get => fields.SchoolId[this]; set => fields.SchoolId[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey(typeof(Syllabus.ClassRow)), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor(typeof(Syllabus.ClassRow), Async = true)]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), ForeignKey(typeof(Syllabus.SubjectRow)), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    [LookupEditor(typeof(Syllabus.SubjectRow), Async = true)]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Description"), Size(255), QuickSearch, NameProperty]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Academic Year"), NotNull, ForeignKey(typeof(Masters.AcademicYearRow)), LeftJoin(jAcademicYear)]
    [TextualField(nameof(AcademicYearName)), LookupEditor(typeof(Masters.AcademicYearRow), Async = true)]
    public int? AcademicYearId { get => fields.AcademicYearId[this]; set => fields.AcademicYearId[this] = value; }

    [DisplayName("Is Active"), NotNull, DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Teacher Prn"), Origin(jTeacher, nameof(Users.TeacherRow.Prn))]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    [DisplayName("School Name"), Expression($"{jSchool}.[Name]")]
    public string SchoolName { get => fields.SchoolName[this]; set => fields.SchoolName[this] = value; }

    [DisplayName("Class Title"), Origin(jClass, nameof(Syllabus.ClassRow.Title))]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Subject Title"), Origin(jSubject, nameof(Syllabus.SubjectRow.Title))]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    [DisplayName("Academic Year Name"), Origin(jAcademicYear, nameof(Masters.AcademicYearRow.Name))]
    public string AcademicYearName { get => fields.AcademicYearName[this]; set => fields.AcademicYearName[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field TeacherId;
        public Int32Field SchoolId;
        public Int32Field ClassId;
        public Int32Field SubjectId;
        public StringField Description;
        public Int32Field AcademicYearId;
        public BooleanField IsActive;

        public StringField TeacherPrn;
        public StringField SchoolName;
        public StringField ClassTitle;
        public StringField SubjectTitle;
        public StringField AcademicYearName;
    }
}