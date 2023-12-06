using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Settings;

[ConnectionKey("Default"), Module("Settings"), TableName("Smtp")]
[DisplayName("Smtp"), InstanceName("Smtp")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class SmtpRow : LoggingRow<SmtpRow.RowFields>, IIdRow, INameRow
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

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Server;
        public Int32Field Port;
        public StringField Username;
        public StringField Password;
        public BooleanField IsSsl;
        public BooleanField IsActive;

    }
}