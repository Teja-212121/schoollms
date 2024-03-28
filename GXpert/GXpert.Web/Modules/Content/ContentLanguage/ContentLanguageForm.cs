using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentLanguage")]
[BasedOnRow(typeof(ContentLanguageRow), CheckNames = true)]
public class ContentLanguageForm
{
    public string Name { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
    
}