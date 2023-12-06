using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank.Columns;

[ColumnsScript("QuestionBank.CommonData")]
[BasedOnRow(typeof(CommonDataRow), CheckNames = true)]
public class CommonDataColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string CommonDataTitle { get; set; }
    [EditLink]
    public string CommonData { get; set; }
}