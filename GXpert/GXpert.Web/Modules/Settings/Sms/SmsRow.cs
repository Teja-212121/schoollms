using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Settings;

[ConnectionKey("Default"), Module("Settings"), TableName("SMS")]
[DisplayName("Sms"), InstanceName("Sms")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class SmsRow : LoggingRow<SmsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Api Key"), Column("APIKey"), Size(500), NotNull, QuickSearch, NameProperty]
    public string ApiKey { get => fields.ApiKey[this]; set => fields.ApiKey[this] = value; }

    [DisplayName("Sender"), Size(500)]
    public string Sender { get => fields.Sender[this]; set => fields.Sender[this] = value; }

    [DisplayName("Entity Id"), Size(500), NotNull]
    public string EntityId { get => fields.EntityId[this]; set => fields.EntityId[this] = value; }

    [DisplayName("Template Id"), Size(500), NotNull]
    public string TemplateId { get => fields.TemplateId[this]; set => fields.TemplateId[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField ApiKey;
        public StringField Sender;
        public StringField EntityId;
        public StringField TemplateId;
        public BooleanField IsActive;

    }
}