using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Content.Columns;

[ColumnsScript("Content.ContentCategory")]
[BasedOnRow(typeof(ContentCategoryRow), CheckNames = true)]
public class ContentCategoryColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
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