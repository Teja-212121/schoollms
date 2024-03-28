using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentLicense")]
[BasedOnRow(typeof(ContentLicenseRow), CheckNames = true)]
public class ContentLicenseForm
{
    public string Name { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
   
}