using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Syllabus;

[ConnectionKey("Default"), Module("Syllabus"), TableName("Course")]
[DisplayName("Course"), InstanceName("Course")]
[ReadPermission(PermissionKeys.SyllabusManagement.View)]
[ModifyPermission(PermissionKeys.SyllabusManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Syllabus.Course")]
public sealed class CourseRow : LoggingRow<CourseRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Sort Order")]
    public short? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Thumbnail"), Size(500),FileUploadEditor]
    public string Thumbnail { get => fields.Thumbnail[this]; set => fields.Thumbnail[this] = value; }
    

    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public StringField Description;
        public Int16Field SortOrder;
        public StringField Thumbnail;
        public BooleanField IsActive;

    }
}