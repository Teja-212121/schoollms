using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Exams.Columns;

[ColumnsScript("Exams.ExamSection")]
[BasedOnRow(typeof(ExamSectionRow), CheckNames = true)]
public class ExamSectionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ExamTitle { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Instructions { get; set; }
    public int DurationInSeconds { get; set; }
    public float SortOrder { get; set; }
    public string ParentTitle { get; set; }
    public int NumberOfQuestions { get; set; }
    public int NumberOfMandatoryQuestions { get; set; }
    public string SearchTags { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}