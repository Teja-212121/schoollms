using Serenity.ComponentModel;
using System;

namespace GXpert.Settings.Forms;

[FormScript("Settings.Sms")]
[BasedOnRow(typeof(SmsRow), CheckNames = true)]
public class SmsForm
{
    public string ApiKey { get; set; }
    public string Sender { get; set; }
    public string EntityId { get; set; }
    public string TemplateId { get; set; }
}