using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Skills.SkillRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Skills.SkillRow;

namespace GXpert.Skills;

public interface ISkillSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SkillSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISkillSaveHandler
{
    public SkillSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}