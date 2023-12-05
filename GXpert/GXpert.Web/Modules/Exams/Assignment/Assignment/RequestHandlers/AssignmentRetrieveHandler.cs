using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Exams.AssignmentRow>;
using MyRow = GXpert.Exams.AssignmentRow;

namespace GXpert.Exams;

public interface IAssignmentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentRetrieveHandler
{
    public AssignmentRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}