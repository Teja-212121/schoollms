using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GXpert.Masters;

[ConnectionKey("Default"), Module("Masters"), TableName("Projects")]
[DisplayName("Project"), InstanceName("Project")]
[ReadPermission(PermissionKeys.MastersManagement.View)]
[ModifyPermission(PermissionKeys.MastersManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
public sealed class ProjectRow : Row<ProjectRow.RowFields>, IIdRow, INameRow
{
    const string jStudent = nameof(jStudent);
    const string jCourse = nameof(jCourse);
    const string jClass = nameof(jClass);
    const string jSemester = nameof(jSemester);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Student"), ForeignKey(typeof(Users.StudentRow)), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor(typeof(Users.StudentRow), Async = true)]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Course"), NotNull, ForeignKey(typeof(Syllabus.CourseRow)), LeftJoin(jCourse), TextualField(nameof(CourseTitle))]
    [ServiceLookupEditor(typeof(Syllabus.CourseRow), Service = "Syllabus/Course/List")]
    public int? CourseId { get => fields.CourseId[this]; set => fields.CourseId[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey(typeof(Syllabus.ClassRow)), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor(typeof(Syllabus.ClassRow), Async = true)]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Semester"), NotNull, ForeignKey(typeof(Syllabus.SemesterRow)), LeftJoin(jSemester), TextualField(nameof(SemesterTitle))]
    [ServiceLookupEditor(typeof(Syllabus.SemesterRow), Service = "Syllabus/Semester/List")]
    public int? SemesterId { get => fields.SemesterId[this]; set => fields.SemesterId[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("E Type"), Column("eType")]
    public EProjectType? EType { get => (EProjectType)fields.EType[this]; set => fields.EType[this] = (short?)value; }

    [DisplayName("Student Prn"), Origin(jStudent, nameof(Users.StudentRow.Prn))]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("Course Title"), Origin(jCourse, nameof(Syllabus.CourseRow.Title))]
    public string CourseTitle { get => fields.CourseTitle[this]; set => fields.CourseTitle[this] = value; }

    [DisplayName("Class Title"), Origin(jClass, nameof(Syllabus.ClassRow.Title))]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Semester Title"), Origin(jSemester, nameof(Syllabus.SemesterRow.Title))]
    public string SemesterTitle { get => fields.SemesterTitle[this]; set => fields.SemesterTitle[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field StudentId;
        public Int32Field CourseId;
        public Int32Field ClassId;
        public Int32Field SemesterId;
        public StringField Title;
        public StringField Description;
        public Int16Field EType;

        public StringField StudentPrn;
        public StringField CourseTitle;
        public StringField ClassTitle;
        public StringField SemesterTitle;
    }
}