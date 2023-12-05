using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.QuestionBank.QuestionOptionRow>;
using MyRow = GXpert.QuestionBank.QuestionOptionRow;

namespace GXpert.QuestionBank;

public interface IQuestionOptionListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionOptionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionOptionListHandler
{
    public QuestionOptionListHandler(IRequestContext context)
            : base(context)
    {
    }
}