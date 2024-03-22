using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.PreAcademicRow>;
using MyRow = GXpert.Masters.PreAcademicRow;

namespace GXpert.Masters;

public interface IPreAcademicListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PreAcademicListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPreAcademicListHandler
{
    public PreAcademicListHandler(IRequestContext context)
            : base(context)
    {
    }
}