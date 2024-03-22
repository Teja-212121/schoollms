using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.PreAcademicScore")]
[BasedOnRow(typeof(PreAcademicScoreRow), CheckNames = true)]
public class PreAcademicScoreColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string PreAcadamicsExamName { get; set; }
    public DateTime PassedOutDate { get; set; }
    public float MarksObtained { get; set; }
    public float OutOfMarks { get; set; }
    public string StudentPrn { get; set; }
    [EditLink]
    public string Remarks { get; set; }
   
}