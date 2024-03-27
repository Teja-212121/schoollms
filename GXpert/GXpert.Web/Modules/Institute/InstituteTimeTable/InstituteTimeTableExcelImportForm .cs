using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteTimeTableExcelImportForm")]
//[BasedOnRow(typeof(InstituteTimeTableRow), CheckNames = true)]
public class InstituteTimeTableExcelImportForm
{
    [FileUploadEditor, Required]
    public String FileName { get; set; }

}