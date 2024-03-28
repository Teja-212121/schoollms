using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentLanguage")]
[BasedOnRow(typeof(ContentLanguageRow), CheckNames = true)]
public class ContentLanguageForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}