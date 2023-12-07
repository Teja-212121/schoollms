using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Syllabus;

[ConnectionKey("Default"), Module("Syllabus"), TableName("Topics")]
[DisplayName("Topic"), InstanceName("Topic")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Syllabus.Topic")]
public sealed class TopicRow : LoggingRow<TopicRow.RowFields>, IIdRow, INameRow
{
    const string jClass = nameof(jClass);
    const string jMedium = nameof(jMedium);
    const string jSubject = nameof(jSubject);

    [DisplayName("Id"), Identity, IdProperty, LookupInclude]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(2000), NotNull]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public short? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey(typeof(ClassRow)), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [ServiceLookupEditor(typeof(ClassRow))]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Medium"), NotNull, ForeignKey(typeof(MediumRow)), LeftJoin(jMedium), TextualField(nameof(MediumTitle))]
    [ServiceLookupEditor(typeof(MediumRow))]
    public int? MediumId { get => fields.MediumId[this]; set => fields.MediumId[this] = value; }

    [DisplayName("Subject"), NotNull, ForeignKey(typeof(SubjectRow)), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    [ServiceLookupEditor(typeof(SubjectRow), CascadeFrom = "ClassId", CascadeField = "ClassId"), LookupInclude]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Weightage"), NotNull]
    public float? Weightage { get => fields.Weightage[this]; set => fields.Weightage[this] = value; }

    [DisplayName("Thumbnail"), Size(500), NotNull]
    public string Thumbnail { get => fields.Thumbnail[this]; set => fields.Thumbnail[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Class Title"), Origin(jClass, nameof(ClassRow.Title))]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Medium Title"), Origin(jMedium, nameof(MediumRow.Title))]
    public string MediumTitle { get => fields.MediumTitle[this]; set => fields.MediumTitle[this] = value; }

    [DisplayName("Subject Title"), Origin(jSubject, nameof(SubjectRow.Title))]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public StringField Description;
        public Int16Field SortOrder;
        public Int32Field ClassId;
        public Int32Field MediumId;
        public Int32Field SubjectId;
        public SingleField Weightage;
        public StringField Thumbnail;
        public BooleanField IsActive;

        public StringField ClassTitle;
        public StringField MediumTitle;
        public StringField SubjectTitle;
    }
}