using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Exams.Columns;

[ColumnsScript("Exams.Assignment")]
[BasedOnRow(typeof(AssignmentRow), CheckNames = true)]
public class AssignmentColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Description { get; set; }
    public string File { get; set; }
    public string ClassTitle { get; set; }
    public string SubjectTitle { get; set; }
}