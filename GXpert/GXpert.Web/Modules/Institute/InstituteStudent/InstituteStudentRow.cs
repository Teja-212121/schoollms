﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Institute;

[ConnectionKey("Default"), Module("Institute"), TableName("InstituteStudents")]
[DisplayName("Institute Student"), InstanceName("Institute Student")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class InstituteStudentRow : Row<InstituteStudentRow.RowFields>, IIdRow, INameRow
{
    const string jStudent = nameof(jStudent);
    const string jSchool = nameof(jSchool);
    const string jClass = nameof(jClass);
    const string jAcademicYear = nameof(jAcademicYear);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Student"), NotNull, ForeignKey(typeof(Users.StudentRow)), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor(typeof(Users.StudentRow), Async = true)]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("School"), NotNull, ForeignKey("Institutes", "Id"), LeftJoin(jSchool), TextualField(nameof(SchoolName))]
    public int? SchoolId { get => fields.SchoolId[this]; set => fields.SchoolId[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey(typeof(Syllabus.ClassRow)), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor(typeof(Syllabus.ClassRow), Async = true)]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Division"), Size(255), QuickSearch, NameProperty]
    public string Division { get => fields.Division[this]; set => fields.Division[this] = value; }

    [DisplayName("Roll Number"), Size(50)]
    public string RollNumber { get => fields.RollNumber[this]; set => fields.RollNumber[this] = value; }

    [DisplayName("Description"), Size(255)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Academic Year"), NotNull, ForeignKey(typeof(Masters.AcademicYearRow)), LeftJoin(jAcademicYear)]
    [TextualField(nameof(AcademicYearName)), LookupEditor(typeof(Masters.AcademicYearRow), Async = true)]
    public int? AcademicYearId { get => fields.AcademicYearId[this]; set => fields.AcademicYearId[this] = value; }

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

    [DisplayName("Student Prn"), Origin(jStudent, nameof(Users.StudentRow.Prn))]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("School Name"), Expression($"{jSchool}.[Name]")]
    public string SchoolName { get => fields.SchoolName[this]; set => fields.SchoolName[this] = value; }

    [DisplayName("Class Title"), Origin(jClass, nameof(Syllabus.ClassRow.Title))]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Academic Year Name"), Origin(jAcademicYear, nameof(Masters.AcademicYearRow.Name))]
    public string AcademicYearName { get => fields.AcademicYearName[this]; set => fields.AcademicYearName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field StudentId;
        public Int32Field SchoolId;
        public Int32Field ClassId;
        public StringField Division;
        public StringField RollNumber;
        public StringField Description;
        public Int32Field AcademicYearId;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public BooleanField IsActive;

        public StringField StudentPrn;
        public StringField SchoolName;
        public StringField ClassTitle;
        public StringField AcademicYearName;
    }
}