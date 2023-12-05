using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Settings;

[ConnectionKey("Default"), Module("Settings"), TableName("Smtp")]
[DisplayName("Smtp"), InstanceName("Smtp"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class SmtpRow : Row<SmtpRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Server"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Server { get => fields.Server[this]; set => fields.Server[this] = value; }

    [DisplayName("Port"), NotNull]
    public int? Port { get => fields.Port[this]; set => fields.Port[this] = value; }

    [DisplayName("Username"), Size(500), NotNull]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    [DisplayName("Password"), Size(200), NotNull]
    public string Password { get => fields.Password[this]; set => fields.Password[this] = value; }

    [DisplayName("Is Ssl"), Column("IsSSL")]
    public bool? IsSsl { get => fields.IsSsl[this]; set => fields.IsSsl[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }
}