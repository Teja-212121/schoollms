using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Syllabus.ClassRow;

namespace GXpert.Syllabus;

public interface IClassDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ClassDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IClassDeleteHandler
{
    public ClassDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}