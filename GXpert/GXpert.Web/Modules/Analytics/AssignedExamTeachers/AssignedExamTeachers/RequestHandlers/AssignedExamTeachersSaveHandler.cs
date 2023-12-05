using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Analytics.AssignedExamTeachersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Analytics.AssignedExamTeachersRow;

namespace GXpert.Analytics;

public interface IAssignedExamTeachersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AssignedExamTeachersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAssignedExamTeachersSaveHandler
{
    public AssignedExamTeachersSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}