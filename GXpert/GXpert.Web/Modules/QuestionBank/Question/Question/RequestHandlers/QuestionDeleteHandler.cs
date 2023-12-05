using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.QuestionBank.QuestionRow;

namespace GXpert.QuestionBank;

public interface IQuestionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionDeleteHandler
{
    public QuestionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}