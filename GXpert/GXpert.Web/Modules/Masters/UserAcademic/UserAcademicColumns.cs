using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.UserAcademic")]
[BasedOnRow(typeof(UserAcademicRow), CheckNames = true)]
public class UserAcademicColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string StudentPrn { get; set; }
    public string AcademicYearName { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsVerify { get; set; }
    public int VerifyBy { get; set; }
}