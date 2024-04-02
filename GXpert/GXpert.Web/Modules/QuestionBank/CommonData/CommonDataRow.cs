using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank;

[ConnectionKey("Default"), Module("QuestionBank"), TableName("QuestionCommonData")]
[DisplayName("Common Data"), InstanceName("Common Data")]
[ReadPermission(PermissionKeys.QuestionBankManagement.View)]
[ModifyPermission(PermissionKeys.QuestionBankManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
public sealed class CommonDataRow : LoggingRow<CommonDataRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Common Data Title"), Size(500), NotNull]
    public string CommonDataTitle { get => fields.CommonDataTitle[this]; set => fields.CommonDataTitle[this] = value; }

    [DisplayName("Common Data"), NotNull, QuickSearch, NameProperty]
    public string CommonData { get => fields.CommonData[this]; set => fields.CommonData[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField CommonDataTitle;
        public StringField CommonData;
        public BooleanField IsActive;

    }
}