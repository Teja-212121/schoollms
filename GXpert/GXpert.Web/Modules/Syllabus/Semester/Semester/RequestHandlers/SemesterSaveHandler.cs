using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Syllabus.SemesterRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Syllabus.SemesterRow;

namespace GXpert.Syllabus;

public interface ISemesterSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SemesterSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISemesterSaveHandler
{
    public SemesterSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}