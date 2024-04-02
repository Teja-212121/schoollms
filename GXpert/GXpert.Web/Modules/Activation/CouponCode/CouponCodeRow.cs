using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Activation;

[ConnectionKey("Default"), Module("Activation"), TableName("CouponCodes")]
[DisplayName("Coupon Code"), InstanceName("Coupon Code")]
[ReadPermission(PermissionKeys.ActivationManagement.View)]
[ModifyPermission(PermissionKeys.ActivationManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Activation.CouponCode")]
public sealed class CouponCodeRow : LoggingRow<CouponCodeRow.RowFields>, IIdRow, INameRow
{
    const string jPlayList = nameof(jPlayList);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Code"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Code { get => fields.Code[this]; set => fields.Code[this] = value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    [LookupEditor("Playlist.PlayList")]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Validity Type")]
    public EValidityType? ValidityType { get => (EValidityType?)fields.ValidityType[this]; set => fields.ValidityType[this] = (short?)value; }

    [DisplayName("Count Type")]
    public ECountType? CountType { get => (ECountType?)fields.CountType[this]; set => fields.CountType[this] = (short?)value; }

    [DisplayName("Count")]
    public short? Count { get => fields.Count[this]; set => fields.Count[this] = value; }

    [DisplayName("Validity In Days")]
    public short? ValidityInDays { get => fields.ValidityInDays[this]; set => fields.ValidityInDays[this] = value; }

    [DisplayName("Valid Date")]
    public DateTime? ValidDate { get => fields.ValidDate[this]; set => fields.ValidDate[this] = value; }

    [DisplayName("Consumed Count")]
    public int? ConsumedCount { get => fields.ConsumedCount[this]; set => fields.ConsumedCount[this] = value; }

    [DisplayName("Coupon Validity Date")]
    public DateTime? CouponValidityDate { get => fields.CouponValidityDate[this]; set => fields.CouponValidityDate[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Code;
        public Int32Field PlayListId;
        public Int16Field ValidityType;
        public Int16Field CountType;
        public Int16Field Count;
        public Int16Field ValidityInDays;
        public DateTimeField ValidDate;
        public Int32Field ConsumedCount;
        public DateTimeField CouponValidityDate;
        public Int16Field IsActive;

        public StringField PlayListTitle;
    }
}