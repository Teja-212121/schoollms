using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Syllabus.ClassRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Syllabus.ClassRow;

namespace GXpert.Syllabus;

public interface IClassSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ClassSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IClassSaveHandler
{
    public ClassSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}