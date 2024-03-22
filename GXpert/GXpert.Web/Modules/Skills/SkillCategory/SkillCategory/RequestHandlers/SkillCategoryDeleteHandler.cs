using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Skills.SkillCategoryRow;

namespace GXpert.Skills;

public interface ISkillCategoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SkillCategoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISkillCategoryDeleteHandler
{
    public SkillCategoryDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}