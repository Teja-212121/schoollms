using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.QuestionBank.QuestionOptionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.QuestionBank.QuestionOptionRow;

namespace GXpert.QuestionBank;

public interface IQuestionOptionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionOptionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionOptionSaveHandler
{
    public QuestionOptionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}