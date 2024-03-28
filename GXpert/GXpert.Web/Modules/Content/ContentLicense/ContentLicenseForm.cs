using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentLicense")]
[BasedOnRow(typeof(ContentLicenseRow), CheckNames = true)]
public class ContentLicenseForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}