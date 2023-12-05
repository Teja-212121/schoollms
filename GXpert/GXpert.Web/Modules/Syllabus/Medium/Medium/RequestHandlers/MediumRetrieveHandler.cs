using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Syllabus.MediumRow>;
using MyRow = GXpert.Syllabus.MediumRow;

namespace GXpert.Syllabus;

public interface IMediumRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class MediumRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMediumRetrieveHandler
{
    public MediumRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}