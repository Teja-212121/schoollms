using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Institute;

[ConnectionKey("Default"), Module("Institute"), TableName("InstituteClasses")]
[DisplayName("Institute Class"), InstanceName("Institute Class")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class InstituteClassRow : LoggingRow<InstituteClassRow.RowFields>, IIdRow, INameRow
{
    const string jClass = nameof(jClass);
    const string jMedium = nameof(jMedium);
    const string jClassTeacher = nameof(jClassTeacher);
    const string jAcademicYear = nameof(jAcademicYear);
    const string jInstitute = nameof(jInstitute);
    const string jDepartment = nameof(jDepartment);
    const string jCourse = nameof(jCourse);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey(typeof(Syllabus.ClassRow)), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor(typeof(Syllabus.ClassRow), Async = true)]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Division"), Size(255), QuickSearch, NameProperty]
    public string Division { get => fields.Division[this]; set => fields.Division[this] = value; }

    [DisplayName("Medium"), ForeignKey(typeof(Syllabus.MediumRow)), LeftJoin(jMedium), TextualField(nameof(MediumTitle))]
    [LookupEditor(typeof(Syllabus.MediumRow), Async = true)]
    public int? MediumId { get => fields.MediumId[this]; set => fields.MediumId[this] = value; }

    [DisplayName("Class Teacher"), ForeignKey(typeof(Users.TeacherRow)), LeftJoin(jClassTeacher), TextualField(nameof(ClassTeacherPrn))]
    [LookupEditor(typeof(Users.TeacherRow), Async = true)]
    public int? ClassTeacherId { get => fields.ClassTeacherId[this]; set => fields.ClassTeacherId[this] = value; }

    [DisplayName("Title"), Size(255)]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Academic Year"), NotNull, ForeignKey(typeof(Masters.AcademicYearRow)), LeftJoin(jAcademicYear)]
    [TextualField(nameof(AcademicYearName)), LookupEditor(typeof(Masters.AcademicYearRow), Async = true)]
    public int? AcademicYearId { get => fields.AcademicYearId[this]; set => fields.AcademicYearId[this] = value; }

    
    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Institute"), ForeignKey("Institutes", "Id"), LeftJoin(jInstitute), TextualField(nameof(InstituteName))]
    public int? InstituteId { get => fields.InstituteId[this]; set => fields.InstituteId[this] = value; }

    [DisplayName("Department"), ForeignKey("Departments", "Id"), LeftJoin(jDepartment), TextualField(nameof(DepartmentTitle))]
    public int? DepartmentId { get => fields.DepartmentId[this]; set => fields.DepartmentId[this] = value; }

    [DisplayName("Course"), ForeignKey("Course", "Id"), LeftJoin(jCourse), TextualField(nameof(CourseTitle))]
    public int? CourseId { get => fields.CourseId[this]; set => fields.CourseId[this] = value; }

    [DisplayName("Class Title"), Origin(jClass, nameof(Syllabus.ClassRow.Title))]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Medium Title"), Origin(jMedium, nameof(Syllabus.MediumRow.Title))]
    public string MediumTitle { get => fields.MediumTitle[this]; set => fields.MediumTitle[this] = value; }

    [DisplayName("Class Teacher Prn"), Origin(jClassTeacher, nameof(Users.TeacherRow.Prn))]
    public string ClassTeacherPrn { get => fields.ClassTeacherPrn[this]; set => fields.ClassTeacherPrn[this] = value; }

    [DisplayName("Academic Year Name"), Origin(jAcademicYear, nameof(Masters.AcademicYearRow.Name))]
    public string AcademicYearName { get => fields.AcademicYearName[this]; set => fields.AcademicYearName[this] = value; }

    [DisplayName("Institute Name"), Expression($"{jInstitute}.[Name]")]
    public string InstituteName { get => fields.InstituteName[this]; set => fields.InstituteName[this] = value; }

    [DisplayName("Department Title"), Expression($"{jDepartment}.[Title]")]
    public string DepartmentTitle { get => fields.DepartmentTitle[this]; set => fields.DepartmentTitle[this] = value; }

    [DisplayName("Course Title"), Expression($"{jCourse}.[Title]")]
    public string CourseTitle { get => fields.CourseTitle[this]; set => fields.CourseTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field ClassId;
        public StringField Division;
        public Int32Field MediumId;
        public Int32Field ClassTeacherId;
        public StringField Title;
        public Int32Field AcademicYearId;
        public BooleanField IsActive;
        public Int32Field InstituteId;
        public Int32Field DepartmentId;
        public Int32Field CourseId;

        public StringField ClassTitle;
        public StringField MediumTitle;
        public StringField ClassTeacherPrn;
        public StringField AcademicYearName;
        public StringField InstituteName;
        public StringField DepartmentTitle;
        public StringField CourseTitle;
    }
}