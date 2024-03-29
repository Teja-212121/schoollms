using Serenity.ComponentModel;
using System;

namespace GXpert.Exams.Forms;

[FormScript("Exams.ExamQuestion")]
[BasedOnRow(typeof(ExamQuestionRow), CheckNames = true)]
public class ExamQuestionForm
{
    [HalfWidth]
    public int ExamId { get; set; }
    [HalfWidth]
    public int ExamSectionId { get; set; }
    [HalfWidth]
    public long QuestionId { get; set; }
    [HalfWidth]
    public short EDifficultyLevel { get; set; }
    [HalfWidth]
    public string RightAnswer { get; set; }
    [HalfWidth]
    public float Marks { get; set; }
    [HalfWidth]
    public float SortOrder { get; set; }
    [HalfWidth]
    public int CourseId { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SemesterId { get; set; }
    [HalfWidth]
    public int SubjectId { get; set; }
    [HalfWidth]
    public int TopicId { get; set; }
}