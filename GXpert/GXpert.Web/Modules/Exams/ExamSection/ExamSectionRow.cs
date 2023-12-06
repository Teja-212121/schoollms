using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Exams;

[ConnectionKey("Default"), Module("Exams"), TableName("ExamSections")]
[DisplayName("Exam Section"), InstanceName("Exam Section")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ExamSectionRow : LoggingRow<ExamSectionRow.RowFields>, IIdRow, INameRow
{
    const string jExam = nameof(jExam);
    const string jParent = nameof(jParent);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Exam"), NotNull, ForeignKey(typeof(ExamRow)), LeftJoin(jExam), TextualField(nameof(ExamTitle))]
    [ServiceLookupEditor(typeof(ExamRow))]
    public int? ExamId { get => fields.ExamId[this]; set => fields.ExamId[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Instructions")]
    public string Instructions { get => fields.Instructions[this]; set => fields.Instructions[this] = value; }

    [DisplayName("Duration In Seconds")]
    public int? DurationInSeconds { get => fields.DurationInSeconds[this]; set => fields.DurationInSeconds[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public float? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Parent"), ForeignKey(typeof(ExamSectionRow)), LeftJoin(jParent), TextualField(nameof(ParentTitle))]
    [ServiceLookupEditor(typeof(ExamSectionRow))]
    public int? ParentId { get => fields.ParentId[this]; set => fields.ParentId[this] = value; }

    [DisplayName("Number Of Questions")]
    public int? NumberOfQuestions { get => fields.NumberOfQuestions[this]; set => fields.NumberOfQuestions[this] = value; }

    [DisplayName("Number Of Mandatory Questions")]
    public int? NumberOfMandatoryQuestions { get => fields.NumberOfMandatoryQuestions[this]; set => fields.NumberOfMandatoryQuestions[this] = value; }

    [DisplayName("Search Tags"), Size(1000)]
    public string SearchTags { get => fields.SearchTags[this]; set => fields.SearchTags[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Exam Title"), Origin(jExam, nameof(ExamRow.Title))]
    public string ExamTitle { get => fields.ExamTitle[this]; set => fields.ExamTitle[this] = value; }

    [DisplayName("Parent Title"), Origin(jParent, nameof(ExamSectionRow.Title))]
    public string ParentTitle { get => fields.ParentTitle[this]; set => fields.ParentTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field ExamId;
        public StringField Title;
        public StringField Instructions;
        public Int32Field DurationInSeconds;
        public SingleField SortOrder;
        public Int32Field ParentId;
        public Int32Field NumberOfQuestions;
        public Int32Field NumberOfMandatoryQuestions;
        public StringField SearchTags;
        public BooleanField IsActive;

        public StringField ExamTitle;
        public StringField ParentTitle;
    }
}