using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Syllabus.SemesterRow>;
using MyRow = GXpert.Syllabus.SemesterRow;

namespace GXpert.Syllabus;

public interface ISemesterListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SemesterListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISemesterListHandler
{
    public SemesterListHandler(IRequestContext context)
            : base(context)
    {
    }
}