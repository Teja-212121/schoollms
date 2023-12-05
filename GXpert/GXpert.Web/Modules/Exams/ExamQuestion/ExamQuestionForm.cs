using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.ExamQuestion")]
[BasedOnRow(typeof(ExamQuestionRow), CheckNames = true)]
public class ExamQuestionForm
{
    public int ExamId { get; set; }
    public int ExamSectionId { get; set; }
    public long QuestionId { get; set; }
    public short EDifficultyLevel { get; set; }
    public string RightAnswer { get; set; }
    public float Marks { get; set; }
    public float SortOrder { get; set; }
    public int ClassId { get; set; }
    public int SubjectId { get; set; }
    public int TopicId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}