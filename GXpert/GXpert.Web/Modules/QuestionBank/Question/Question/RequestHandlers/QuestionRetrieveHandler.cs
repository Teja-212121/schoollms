using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.QuestionBank.QuestionRow>;
using MyRow = GXpert.QuestionBank.QuestionRow;

namespace GXpert.QuestionBank;

public interface IQuestionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionRetrieveHandler
{
    public QuestionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}