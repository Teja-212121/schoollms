using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Settings.Columns;

[ColumnsScript("Settings.Smtp")]
[BasedOnRow(typeof(SmtpRow), CheckNames = true)]
public class SmtpColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Server { get; set; }
    public int Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsSsl { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}