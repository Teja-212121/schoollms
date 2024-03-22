using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Masters;

[ConnectionKey("Default"), Module("Masters"), TableName("PreAcademics")]
[DisplayName("Pre Academic"), InstanceName("Pre Academic")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class PreAcademicRow : LoggingRow<PreAcademicRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Exam Name"), Size(500), NotNull, QuickSearch, NameProperty]
    public string ExamName { get => fields.ExamName[this]; set => fields.ExamName[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Thumbnail"), Size(500)]
    public string Thumbnail { get => fields.Thumbnail[this]; set => fields.Thumbnail[this] = value; }

    

    [DisplayName("Is Active"), NotNull,DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField ExamName;
        public StringField Description;
        public StringField Thumbnail;
       
        public BooleanField IsActive;

    }
}