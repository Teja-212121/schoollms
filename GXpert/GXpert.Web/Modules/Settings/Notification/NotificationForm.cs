using Serenity.ComponentModel;
using System;

namespace GXpert.Settings.Forms;

[FormScript("Settings.Notification")]
[BasedOnRow(typeof(NotificationRow), CheckNames = true)]
public class NotificationForm
{
    public Guid NotificationGuid { get; set; }
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