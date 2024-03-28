using Serenity.ComponentModel;

namespace GXpert.Masters.Forms;

[FormScript("Masters.UserAcademic")]
[BasedOnRow(typeof(UserAcademicRow), CheckNames = true)]
public class UserAcademicForm
{
    public int StudentId { get; set; }
    public int AcademicYearId { get; set; }
    public string Title { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
    public bool IsVerify { get; set; }
    public int VerifyBy { get; set; }
}