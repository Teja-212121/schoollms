using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.QuestionBank.QuestionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.QuestionBank.QuestionRow;

namespace GXpert.QuestionBank;

public interface IQuestionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionSaveHandler
{
    public QuestionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}