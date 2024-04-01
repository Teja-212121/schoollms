using GXpert.QuestionBank;
using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Exams;

[ConnectionKey("Default"), Module("Exams"), TableName("Exams")]
[DisplayName("Exam"), InstanceName("Exam")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Exams.Exam")]

public sealed class ExamRow : LoggingRow<ExamRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("E Exam Type"), NotNull]
    public EExamTypes? EExamType { get => (EExamTypes)fields.EExamType[this]; set => fields.EExamType[this] = (short?)value; }

    [DisplayName("E Exam State")]
    public EExamState? EExamState { get => (EExamState?)fields.EExamState[this]; set => fields.EExamState[this] = (short?)value; }

    [DisplayName("Question Paper Path"),FileUploadEditor]
    public string QuestionPaperPath { get => fields.QuestionPaperPath[this]; set => fields.QuestionPaperPath[this] = value; }

    [DisplayName("Model Answer Paper Path"),FileUploadEditor]
    public string ModelAnswerPaperPath { get => fields.ModelAnswerPaperPath[this]; set => fields.ModelAnswerPaperPath[this] = value; }

    [DisplayName("Exam Duration")]
    public int? ExamDuration { get => fields.ExamDuration[this]; set => fields.ExamDuration[this] = value; }

    [DisplayName("Max Marks")]
    public float? MaxMarks { get => fields.MaxMarks[this]; set => fields.MaxMarks[this] = value; }

    [DisplayName("Negative Marks")]
    public float? NegativeMarks { get => fields.NegativeMarks[this]; set => fields.NegativeMarks[this] = value; }

    [DisplayName("E Exam Navigation")]
    public EQuestionNavigation? EExamNavigation { get => (EQuestionNavigation?)fields.EExamNavigation[this]; set => fields.EExamNavigation[this] = (short?)value; }

    [DisplayName("E Section Navigation")]
    public EQuestionNavigation? ESectionNavigation { get => (EQuestionNavigation?)fields.ESectionNavigation[this]; set => fields.ESectionNavigation[this] = (short?)value; }

    [DisplayName("E Question Navigation")]
    public EQuestionNavigation? EQuestionNavigation { get => (EQuestionNavigation?)fields.EQuestionNavigation[this]; set => fields.EQuestionNavigation[this] = (short?)value; }

    [DisplayName("E Result Type")]
    public EResultTypes? EResultType { get => (EResultTypes)fields.EResultType[this]; set => fields.EResultType[this] = (short?)value; }

    [DisplayName("E Option Display Type")]
    public EOptionDisplayTypes? EOptionDisplayType { get => (EOptionDisplayTypes?)fields.EOptionDisplayType[this]; set => fields.EOptionDisplayType[this] = (short?)value; }

    [DisplayName("Has Negative Marketing")]
    public bool? HasNegativeMarketing { get => fields.HasNegativeMarketing[this]; set => fields.HasNegativeMarketing[this] = value; }

    [DisplayName("Instructions"), HtmlContentEditor(Rows = 3)]
    public string Instructions { get => fields.Instructions[this]; set => fields.Instructions[this] = value; }

    [DisplayName("Search Tags"), Size(1000)]
    public string SearchTags { get => fields.SearchTags[this]; set => fields.SearchTags[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("ExamSection"), MasterDetailRelation(foreignKey: nameof(ExamSectionRow.ExamId)), NotMapped, NotNull]
    public List<ExamSectionRow> ExamSection
    {
        get { return Fields.ExamSection[this]; }
        set { Fields.ExamSection[this] = value; }
    }
    [DisplayName("Exam Questions"), MasterDetailRelation(foreignKey: "ExamId", IncludeColumns = "Question"), NotMapped]
    public List<ExamQuestionRow> ExamQuestions
    {
        get { return Fields.ExamQuestions[this]; }
        set { Fields.ExamQuestions[this] = value; }
    }
    public class RowFields : LoggingRowFields
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
        public RowListField<ExamSectionRow> ExamSection;
        public RowListField<ExamQuestionRow> ExamQuestions;
        public BooleanField IsActive;

    }
}