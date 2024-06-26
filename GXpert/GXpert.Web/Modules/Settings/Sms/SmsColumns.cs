using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Settings.Columns;

[ColumnsScript("Settings.Sms")]
[BasedOnRow(typeof(SmsRow), CheckNames = true)]
public class SmsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string ApiKey { get; set; }
    public string Sender { get; set; }
    public string EntityId { get; set; }
    public string TemplateId { get; set; }
}