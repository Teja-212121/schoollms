using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Schools;

[ConnectionKey("Default"), Module("Schools"), TableName("SchoolTeachers")]
[DisplayName("School Teacher"), InstanceName("School Teacher")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class SchoolTeacherRow : LoggingRow<SchoolTeacherRow.RowFields>, IIdRow, INameRow
{
    const string jTeacher = nameof(jTeacher);
    const string jSchool = nameof(jSchool);
    const string jClass = nameof(jClass);
    const string jSubject = nameof(jSubject);
    const string jAcademicYear = nameof(jAcademicYear);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Teacher"), NotNull, ForeignKey("Teachers", "Id"), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor("Users.Teacher")]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("School"), NotNull, ForeignKey(typeof(SchoolRow)), LeftJoin(jSchool), TextualField(nameof(SchoolName))]
    [ServiceLookupEditor(typeof(SchoolRow))]
    public int? SchoolId { get => fields.SchoolId[this]; set => fields.SchoolId[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor("Syllabus.Class")]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    [LookupEditor("Syllabus.Subject")]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Description"), Size(255), QuickSearch, NameProperty]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Academic Year"), NotNull, ForeignKey("AcademicYears", "Id"), LeftJoin(jAcademicYear)]
    [TextualField(nameof(AcademicYearName))]
    [LookupEditor("Masters.AcademicYear")]
    public int? AcademicYearId { get => fields.AcademicYearId[this]; set => fields.AcademicYearId[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Teacher Prn"), Expression($"{jTeacher}.[PRN]")]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    [DisplayName("School Name"), Origin(jSchool, nameof(SchoolRow.Name))]
    public string SchoolName { get => fields.SchoolName[this]; set => fields.SchoolName[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Subject Title"), Expression($"{jSubject}.[Title]")]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    [DisplayName("Academic Year Name"), Expression($"{jAcademicYear}.[Name]")]
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