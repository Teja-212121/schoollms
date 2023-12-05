using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Syllabus.ClassRow>;
using MyRow = GXpert.Syllabus.ClassRow;

namespace GXpert.Syllabus;

public interface IClassListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ClassListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IClassListHandler
{
    public ClassListHandler(IRequestContext context)
            : base(context)
    {
    }
}