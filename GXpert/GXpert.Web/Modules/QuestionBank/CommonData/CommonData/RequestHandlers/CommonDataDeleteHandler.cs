using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.QuestionBank.CommonDataRow;

namespace GXpert.QuestionBank;

public interface ICommonDataDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CommonDataDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICommonDataDeleteHandler
{
    public CommonDataDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}