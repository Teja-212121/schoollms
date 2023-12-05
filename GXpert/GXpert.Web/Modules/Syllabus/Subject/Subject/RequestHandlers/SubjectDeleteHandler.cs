using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Syllabus.SubjectRow;

namespace GXpert.Syllabus;

public interface ISubjectDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SubjectDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISubjectDeleteHandler
{
    public SubjectDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}