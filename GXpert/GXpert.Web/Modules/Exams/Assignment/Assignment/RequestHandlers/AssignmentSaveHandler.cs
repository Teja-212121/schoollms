using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Exams.AssignmentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Exams.AssignmentRow;

namespace GXpert.Exams;

public interface IAssignmentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentSaveHandler
{
    public AssignmentSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}