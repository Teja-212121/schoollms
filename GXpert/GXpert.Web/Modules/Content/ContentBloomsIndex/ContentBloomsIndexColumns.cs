using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Content.Columns;

[ColumnsScript("Content.ContentBloomsIndex")]
[BasedOnRow(typeof(ContentBloomsIndexRow), CheckNames = true)]
public class ContentBloomsIndexColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ContentTitle { get; set; }
    public string BloomsIndexCoginitiveSkill { get; set; }
    public float Weightage { get; set; }
}