using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.QuestionBank.CommonDataRow>;
using MyRow = GXpert.QuestionBank.CommonDataRow;

namespace GXpert.QuestionBank;

public interface ICommonDataListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CommonDataListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICommonDataListHandler
{
    public CommonDataListHandler(IRequestContext context)
            : base(context)
    {
    }
}