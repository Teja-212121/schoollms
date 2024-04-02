using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Syllabus;

[ConnectionKey("Default"), Module("Syllabus"), TableName("Semester")]
[DisplayName("Semester"), InstanceName("Semester")]
[ReadPermission(PermissionKeys.SyllabusManagement.View)]
[ModifyPermission(PermissionKeys.SyllabusManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Syllabus.Semester")]
public sealed class SemesterRow : LoggingRow<SemesterRow.RowFields>, IIdRow, INameRow
{
    const string jCourse = nameof(jCourse);
    const string jClass = nameof(jClass);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Course"), NotNull, ForeignKey(typeof(CourseRow)), LeftJoin(jCourse), TextualField(nameof(CourseTitle))]
    [ServiceLookupEditor(typeof(CourseRow), Service = "Syllabus/Course/List")]
    public int? CourseId { get => fields.CourseId[this]; set => fields.CourseId[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey(typeof(ClassRow)), LeftJoin(jClass)]
    [LookupEditor(typeof(ClassRow), CascadeFrom = "CourseId", CascadeField = "CourseId")]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Sort Order")]
    public short? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Is Active"),DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Course Title"), Origin(jCourse, nameof(CourseRow.Title))]
    public string CourseTitle { get => fields.CourseTitle[this]; set => fields.CourseTitle[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public Int32Field CourseId;
        public Int32Field ClassId;
        public StringField Description;
        public Int16Field SortOrder;
        public BooleanField IsActive;
        public StringField CourseTitle;
        public StringField ClassTitle;
    }
}