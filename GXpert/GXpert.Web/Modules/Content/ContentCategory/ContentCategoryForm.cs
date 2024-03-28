using Serenity.ComponentModel;
using System;

namespace GXpert.Content.Forms;

[FormScript("Content.ContentCategory")]
[BasedOnRow(typeof(ContentCategoryRow), CheckNames = true)]
public class ContentCategoryForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsGlobal { get; set; }
    public int MediaCount { get; set; }
    public string Thumbnail { get; set; }
    public string ListingThumbnail { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}