using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.QuestionBank.QuestionRow>;
using MyRow = GXpert.QuestionBank.QuestionRow;

namespace GXpert.QuestionBank;

public interface IQuestionListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionListHandler
{
    public QuestionListHandler(IRequestContext context)
            : base(context)
    {
    }
}