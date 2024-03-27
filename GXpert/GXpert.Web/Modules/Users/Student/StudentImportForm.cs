using Serenity.ComponentModel;
using System;

namespace GXpert.Users.Forms;

[FormScript("Users.StudentImport")]
//[BasedOnRow(typeof(StudentRow), CheckNames = true)]
public class StudentImportForm
{
    [FileUploadEditor, Required]
    [HalfWidth]
    public string FileName { get; set; }
}