using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GXpert.Masters;

[ConnectionKey("Default"), Module("Masters"), TableName("UserAcademics")]
[DisplayName("User Academic"), InstanceName("User Academic")]
[ReadPermission(PermissionKeys.MastersManagement.View)]
[ModifyPermission(PermissionKeys.MastersManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
public sealed class UserAcademicRow : Row<UserAcademicRow.RowFields>, IIdRow, INameRow
{
    const string jStudent = nameof(jStudent);
    const string jAcademicYear = nameof(jAcademicYear);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Student"), ForeignKey(typeof(Users.StudentRow)), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor(typeof(Users.StudentRow), Async = true)]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("Academic Year"), NotNull, ForeignKey(typeof(AcademicYearRow)), LeftJoin(jAcademicYear)]
    [TextualField(nameof(AcademicYearName)), LookupEditor(typeof(AcademicYearRow), Async = true)]
    public int? AcademicYearId { get => fields.AcademicYearId[this]; set => fields.AcademicYearId[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Is Verify")]
    public bool? IsVerify { get => fields.IsVerify[this]; set => fields.IsVerify[this] = value; }

    [DisplayName("Verify By")]
    public int? VerifyBy { get => fields.VerifyBy[this]; set => fields.VerifyBy[this] = value; }

    [DisplayName("Student Prn"), Origin(jStudent, nameof(Users.StudentRow.Prn))]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("Academic Year Name"), Origin(jAcademicYear, nameof(AcademicYearRow.Name))]
    public string AcademicYearName { get => fields.AcademicYearName[this]; set => fields.AcademicYearName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field StudentId;
        public Int32Field AcademicYearId;
        public StringField Title;
        public StringField Description;
        public BooleanField IsVerify;
        public Int32Field VerifyBy;

        public StringField StudentPrn;
        public StringField AcademicYearName;
    }
}