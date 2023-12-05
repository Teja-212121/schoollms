using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Settings.Columns;

[ColumnsScript("Settings.Notification")]
[BasedOnRow(typeof(NotificationRow), CheckNames = true)]
public class NotificationColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public Guid NotificationGuid { get; set; }
    [EditLink]
    public string Message { get; set; }
    public string Title { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public int SentTries { get; set; }
    public DateTime SentOnUtc { get; set; }
    public bool HasError { get; set; }
    public string Result { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}