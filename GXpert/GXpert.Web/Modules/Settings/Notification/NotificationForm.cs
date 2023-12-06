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
}