using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Analytics;

[ConnectionKey("Default"), Module("Analytics"), TableName("ExamAttemptQuestions")]
[DisplayName("Exam Attempt Question"), InstanceName("Exam Attempt Question")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ExamAttemptQuestionRow : Row<ExamAttemptQuestionRow.RowFields>, IIdRow, INameRow
{
    const string jExamAttempt = nameof(jExamAttempt);
    const string jExamQuestion = nameof(jExamQuestion);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Exam Attempt"), NotNull, ForeignKey(typeof(ExamAttemptRow)), LeftJoin(jExamAttempt)]
    [TextualField(nameof(ExamAttemptStudentAnswerSheetUpload)), ServiceLookupEditor(typeof(ExamAttemptRow))]
    public int? ExamAttemptId { get => fields.ExamAttemptId[this]; set => fields.ExamAttemptId[this] = value; }

    [DisplayName("Exam Question"), NotNull, ForeignKey("ExamQuestions", "Id"), LeftJoin(jExamQuestion)]
    [TextualField(nameof(ExamQuestionRightAnswer))]
    public int? ExamQuestionId { get => fields.ExamQuestionId[this]; set => fields.ExamQuestionId[this] = value; }

    [DisplayName("Option Selected"), Size(255), QuickSearch, NameProperty]
    public string OptionSelected { get => fields.OptionSelected[this]; set => fields.OptionSelected[this] = value; }

    [DisplayName("Marks Obtained"), NotNull]
    public int? MarksObtained { get => fields.MarksObtained[this]; set => fields.MarksObtained[this] = value; }

    [DisplayName("Attemptstatus"), NotNull]
    public short? Attemptstatus { get => fields.Attemptstatus[this]; set => fields.Attemptstatus[this] = value; }

    [DisplayName("Out Ofmarks"), NotNull]
    public int? OutOfmarks { get => fields.OutOfmarks[this]; set => fields.OutOfmarks[this] = value; }

    [DisplayName("Result"), Size(50)]
    public string Result { get => fields.Result[this]; set => fields.Result[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date"), NotNull]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id"), NotNull]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Exam Attempt Student Answer Sheet Upload"), Origin(jExamAttempt, nameof(ExamAttemptRow.StudentAnswerSheetUpload))]
    public string ExamAttemptStudentAnswerSheetUpload { get => fields.ExamAttemptStudentAnswerSheetUpload[this]; set => fields.ExamAttemptStudentAnswerSheetUpload[this] = value; }

    [DisplayName("Exam Question Right Answer"), Expression($"{jExamQuestion}.[RightAnswer]")]
    public string ExamQuestionRightAnswer { get => fields.ExamQuestionRightAnswer[this]; set => fields.ExamQuestionRightAnswer[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field ExamAttemptId;
        public Int32Field ExamQuestionId;
        public StringField OptionSelected;
        public Int32Field MarksObtained;
        public Int16Field Attemptstatus;
        public Int32Field OutOfmarks;
        public StringField Result;
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public BooleanField IsActive;

        public StringField ExamAttemptStudentAnswerSheetUpload;
        public StringField ExamQuestionRightAnswer;
    }
}