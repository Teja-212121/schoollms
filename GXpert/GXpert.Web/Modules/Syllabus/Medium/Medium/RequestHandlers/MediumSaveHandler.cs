using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Syllabus.MediumRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Syllabus.MediumRow;

namespace GXpert.Syllabus;

public interface IMediumSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MediumSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMediumSaveHandler
{
    public MediumSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}