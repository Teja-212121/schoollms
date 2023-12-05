using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Syllabus.MediumRow;

namespace GXpert.Syllabus;

public interface IMediumDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class MediumDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMediumDeleteHandler
{
    public MediumDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}