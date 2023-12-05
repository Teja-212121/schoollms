using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.QuestionBank.QuestionOptionRow;

namespace GXpert.QuestionBank;

public interface IQuestionOptionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionOptionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionOptionDeleteHandler
{
    public QuestionOptionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}