﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Activation;

[ConnectionKey("Default"), Module("Activation"), TableName("CouponCodes")]
[DisplayName("Coupon Code"), InstanceName("Coupon Code")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class CouponCodeRow : Row<CouponCodeRow.RowFields>, IIdRow, INameRow
{
    const string jPlayList = nameof(jPlayList);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Code"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Code { get => fields.Code[this]; set => fields.Code[this] = value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Validity Type")]
    public short? ValidityType { get => fields.ValidityType[this]; set => fields.ValidityType[this] = value; }

    [DisplayName("Count Type")]
    public short? CountType { get => fields.CountType[this]; set => fields.CountType[this] = value; }

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

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public short? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    public class RowFields : RowFieldsBase
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
        public DateTimeField InsertDate;
        public Int32Field InsertUserId;
        public DateTimeField UpdateDate;
        public Int32Field UpdateUserId;
        public Int16Field IsActive;

        public StringField PlayListTitle;
    }
}