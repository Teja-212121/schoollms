using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Syllabus.ClassRow>;
using MyRow = GXpert.Syllabus.ClassRow;

namespace GXpert.Syllabus;

public interface IClassRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ClassRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IClassRetrieveHandler
{
    public ClassRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}