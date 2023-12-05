using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.QuestionBank.CommonDataRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.QuestionBank.CommonDataRow;

namespace GXpert.QuestionBank;

public interface ICommonDataSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CommonDataSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICommonDataSaveHandler
{
    public CommonDataSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}