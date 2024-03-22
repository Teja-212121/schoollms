using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.PreAcademicRow;

namespace GXpert.Masters;

public interface IPreAcademicDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PreAcademicDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPreAcademicDeleteHandler
{
    public PreAcademicDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}