using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Syllabus.SubjectRow>;
using MyRow = GXpert.Syllabus.SubjectRow;

namespace GXpert.Syllabus;

public interface ISubjectListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SubjectListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISubjectListHandler
{
    public SubjectListHandler(IRequestContext context)
            : base(context)
    {
    }
}