using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Syllabus.MediumRow>;
using MyRow = GXpert.Syllabus.MediumRow;

namespace GXpert.Syllabus;

public interface IMediumListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class MediumListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMediumListHandler
{
    public MediumListHandler(IRequestContext context)
            : base(context)
    {
    }
}