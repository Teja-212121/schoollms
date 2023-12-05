using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.CommonData")]
[BasedOnRow(typeof(CommonDataRow), CheckNames = true)]
public class CommonDataForm
{
    public string CommonDataTitle { get; set; }
    public string CommonData { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}