using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank;

[ConnectionKey("Default"), Module("QuestionBank"), TableName("QuestionOptions")]
[DisplayName("Question Option"), InstanceName("Question Option")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class QuestionOptionRow : LoggingRow<QuestionOptionRow.RowFields>, IIdRow, INameRow
{
    const string jQuestion = nameof(jQuestion);

    [DisplayName("Id"), Identity, IdProperty]
    public long? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Question"), NotNull, ForeignKey(typeof(QuestionRow)), LeftJoin(jQuestion), TextualField(nameof(QuestionText))]
    [ServiceLookupEditor(typeof(QuestionRow))]
    public long? QuestionId { get => fields.QuestionId[this]; set => fields.QuestionId[this] = value; }

    [DisplayName("Option Text"), NotNull, QuickSearch, NameProperty, HtmlContentEditor(Rows = 3)]
    public string OptionText { get => fields.OptionText[this]; set => fields.OptionText[this] = value; }

    [DisplayName("Is Correct")]
    public bool? IsCorrect { get => fields.IsCorrect[this]; set => fields.IsCorrect[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public float? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Weightage")]
    public float? Weightage { get => fields.Weightage[this]; set => fields.Weightage[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Question Question Text"), Origin(jQuestion, nameof(QuestionRow.QuestionText))]
    public string QuestionText { get => fields.QuestionText[this]; set => fields.QuestionText[this] = value; }
    //public string Notes { get; internal set; }
    //public object QuestionOptionText { get; internal set; }

    public class RowFields : LoggingRowFields
    {
        public Int64Field Id;
        public Int64Field QuestionId;
        public StringField OptionText;
        public BooleanField IsCorrect;
        public SingleField SortOrder;
        public SingleField Weightage;
        public BooleanField IsActive;

        public StringField QuestionText;
    }
}