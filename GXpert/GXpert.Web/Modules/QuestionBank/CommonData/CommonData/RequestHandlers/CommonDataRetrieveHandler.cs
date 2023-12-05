using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.QuestionBank.CommonDataRow>;
using MyRow = GXpert.QuestionBank.CommonDataRow;

namespace GXpert.QuestionBank;

public interface ICommonDataRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CommonDataRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICommonDataRetrieveHandler
{
    public CommonDataRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}