using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Schools;

[ConnectionKey("Default"), Module("Schools"), TableName("SchoolStudents")]
[DisplayName("School Student"), InstanceName("School Student")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class SchoolStudentRow : LoggingRow<SchoolStudentRow.RowFields>, IIdRow, INameRow
{
    const string jStudent = nameof(jStudent);
    const string jSchool = nameof(jSchool);
    const string jClass = nameof(jClass);
    const string jAcademicYear = nameof(jAcademicYear);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Student"), NotNull, ForeignKey("Students", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor("Users.Student")]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("School"), NotNull, ForeignKey(typeof(SchoolRow)), LeftJoin(jSchool), TextualField(nameof(SchoolName))]
    [ServiceLookupEditor(typeof(SchoolRow))]
    public int? SchoolId { get => fields.SchoolId[this]; set => fields.SchoolId[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor("Syllabus.Class")]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Division"), Size(255), QuickSearch, NameProperty]
    public string Division { get => fields.Division[this]; set => fields.Division[this] = value; }

    [DisplayName("Roll Number"), Size(50)]
    public string RollNumber { get => fields.RollNumber[this]; set => fields.RollNumber[this] = value; }

    [DisplayName("Description"), Size(255)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Academic Year"), NotNull, ForeignKey("AcademicYears", "Id"), LeftJoin(jAcademicYear)]
    [TextualField(nameof(AcademicYearName))]
    [LookupEditor("Masters.AcademicYear")]
    public int? AcademicYearId { get => fields.AcademicYearId[this]; set => fields.AcademicYearId[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Student Prn"), Expression($"{jStudent}.[PRN]")]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("School Name"), Origin(jSchool, nameof(SchoolRow.Name))]
    public string SchoolName { get => fields.SchoolName[this]; set => fields.SchoolName[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Academic Year Name"), Expression($"{jAcademicYear}.[Name]")]
    public string AcademicYearName { get => fields.AcademicYearName[this]; set => fields.AcademicYearName[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field StudentId;
        public Int32Field SchoolId;
        public Int32Field ClassId;
        public StringField Division;
        public StringField RollNumber;
        public StringField Description;
        public Int32Field AcademicYearId;
        public BooleanField IsActive;

        public StringField StudentPrn;
        public StringField SchoolName;
        public StringField ClassTitle;
        public StringField AcademicYearName;
    }
}