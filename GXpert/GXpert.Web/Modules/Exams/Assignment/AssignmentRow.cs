using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Exams;

[ConnectionKey("Default"), Module("Exams"), TableName("Assignments")]
[DisplayName("Assignment"), InstanceName("Assignment")]
[ReadPermission(PermissionKeys.ExamsManagement.View)]
[ModifyPermission(PermissionKeys.ExamsManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Exams.Assignment")]
public sealed class AssignmentRow : LoggingRow<AssignmentRow.RowFields>, IIdRow, INameRow
{
    const string jClass = nameof(jClass);
    const string jSubject = nameof(jSubject);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("File"), NotNull]
    public string File { get => fields.File[this]; set => fields.File[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor("Syllabus.Class")]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), NotNull, ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    [LookupEditor("Syllabus.Subject")]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Subject Title"), Expression($"{jSubject}.[Title]")]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public StringField Description;
        public StringField File;
        public Int32Field ClassId;
        public Int32Field SubjectId;
        public BooleanField IsActive;

        public StringField ClassTitle;
        public StringField SubjectTitle;
    }
}