using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Exams;

[ConnectionKey("Default"), Module("Exams"), TableName("Exams")]
[DisplayName("Exam"), InstanceName("Exam")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Exams.Exam")]

public sealed class ExamRow : Row<ExamRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("E Exam Type"), NotNull]
    public short? EExamType { get => fields.EExamType[this]; set => fields.EExamType[this] = value; }

    [DisplayName("E Exam State")]
    public short? EExamState { get => fields.EExamState[this]; set => fields.EExamState[this] = value; }

    [DisplayName("Question Paper Path")]
    public string QuestionPaperPath { get => fields.QuestionPaperPath[this]; set => fields.QuestionPaperPath[this] = value; }

    [DisplayName("Model Answer Paper Path")]
    public string ModelAnswerPaperPath { get => fields.ModelAnswerPaperPath[this]; set => fields.ModelAnswerPaperPath[this] = value; }

    [DisplayName("Exam Duration")]
    public int? ExamDuration { get => fields.ExamDuration[this]; set => fields.ExamDuration[this] = value; }

    [DisplayName("Max Marks")]
    public float? MaxMarks { get => fields.MaxMarks[this]; set => fields.MaxMarks[this] = value; }

    [DisplayName("Negative Marks")]
    public float? NegativeMarks { get => fields.NegativeMarks[this]; set => fields.NegativeMarks[this] = value; }

    [DisplayName("E Exam Navigation")]
    public short? EExamNavigation { get => fields.EExamNavigation[this]; set => fields.EExamNavigation[this] = value; }

    [DisplayName("E Section Navigation")]
    public short? ESectionNavigation { get => fields.ESectionNavigation[this]; set => fields.ESectionNavigation[this] = value; }

    [DisplayName("E Question Navigation")]
    public short? EQuestionNavigation { get => fields.EQuestionNavigation[this]; set => fields.EQuestionNavigation[this] = value; }

    [DisplayName("E Result Type")]
    public short? EResultType { get => fields.EResultType[this]; set => fields.EResultType[this] = value; }

    [DisplayName("E Option Display Type")]
    public short? EOptionDisplayType { get => fields.EOptionDisplayType[this]; set => fields.EOptionDisplayType[this] = value; }

    [DisplayName("Has Negative Marketing")]
    public bool? HasNegativeMarketing { get => fields.HasNegativeMarketing[this]; set => fields.HasNegativeMarketing[this] = value; }

    [DisplayName("Instructions")]
    public string Instructions { get => fields.Instructions[this]; set => fields.Instructions[this] = value; }

    [DisplayName("Search Tags"), Size(1000)]
    public string SearchTags { get => fields.SearchTags[this]; set => fields.SearchTags[this] = value; }

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

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Title;
        public Int16Field EExamType;
        public Int16Field EExamState;
        public StringField QuestionPaperPath;
        public StringField ModelAnswerPaperPath;
        public Int32Field ExamDuration;
        public SingleField MaxMarks;
        public SingleField NegativeMarks;
        public Int16Field EExamNavigation;
        public Int16Field ESectionNavigation;
        public Int16Field EQuestionNavigation;
        public Int16Field EResultType;
        public Int16Field EOptionDisplayType;
        public BooleanField HasNegativeMarketing;
        public StringField Instructions;
        public StringField SearchTags;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public BooleanField IsActive;

    }
}