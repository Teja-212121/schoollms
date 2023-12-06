using Serenity.ComponentModel;
using System;

namespace GXpert.Settings.Forms;

[FormScript("Settings.Smtp")]
[BasedOnRow(typeof(SmtpRow), CheckNames = true)]
public class SmtpForm
{
    public string Server { get; set; }
    public int Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsSsl { get; set; }
}