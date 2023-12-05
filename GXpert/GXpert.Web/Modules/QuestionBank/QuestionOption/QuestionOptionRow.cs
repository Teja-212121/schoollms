using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank;

[ConnectionKey("Default"), Module("QuestionBank"), TableName("QuestionOptions")]
[DisplayName("Question Option"), InstanceName("Question Option"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class QuestionOptionRow : Row<QuestionOptionRow.RowFields>, IIdRow, INameRow
{
    const string jQuestion = nameof(jQuestion);

    [DisplayName("Id"), Identity, IdProperty]
    public long? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Question"), NotNull, ForeignKey(typeof(QuestionRow)), LeftJoin(jQuestion), TextualField(nameof(QuestionText))]
    [ServiceLookupEditor(typeof(QuestionRow))]
    public long? QuestionId { get => fields.QuestionId[this]; set => fields.QuestionId[this] = value; }

    [DisplayName("Option Text"), NotNull, QuickSearch, NameProperty]
    public string OptionText { get => fields.OptionText[this]; set => fields.OptionText[this] = value; }

    [DisplayName("Is Correct")]
    public bool? IsCorrect { get => fields.IsCorrect[this]; set => fields.IsCorrect[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public float? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Weightage")]
    public float? Weightage { get => fields.Weightage[this]; set => fields.Weightage[this] = value; }

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

    [DisplayName("Question Question Text"), Origin(jQuestion, nameof(QuestionRow.QuestionText))]
    public string QuestionText { get => fields.QuestionText[this]; set => fields.QuestionText[this] = value; }
}