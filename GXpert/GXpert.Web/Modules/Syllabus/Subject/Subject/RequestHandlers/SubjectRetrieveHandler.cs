using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Syllabus.SubjectRow>;
using MyRow = GXpert.Syllabus.SubjectRow;

namespace GXpert.Syllabus;

public interface ISubjectRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SubjectRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISubjectRetrieveHandler
{
    public SubjectRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}