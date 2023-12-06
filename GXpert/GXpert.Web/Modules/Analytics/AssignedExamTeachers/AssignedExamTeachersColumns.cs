using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Analytics.Columns;

[ColumnsScript("Analytics.AssignedExamTeachers")]
[BasedOnRow(typeof(AssignedExamTeachersRow), CheckNames = true)]
public class AssignedExamTeachersColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ExamTitle { get; set; }
    public string PlayListTitle { get; set; }
    public string TeacherPrn { get; set; }
}