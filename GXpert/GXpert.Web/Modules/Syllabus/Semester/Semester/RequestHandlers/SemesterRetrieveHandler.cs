using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Syllabus.SemesterRow>;
using MyRow = GXpert.Syllabus.SemesterRow;

namespace GXpert.Syllabus;

public interface ISemesterRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SemesterRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISemesterRetrieveHandler
{
    public SemesterRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}