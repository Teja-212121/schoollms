using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Syllabus.SubjectRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Syllabus.SubjectRow;

namespace GXpert.Syllabus;

public interface ISubjectSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SubjectSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISubjectSaveHandler
{
    public SubjectSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}