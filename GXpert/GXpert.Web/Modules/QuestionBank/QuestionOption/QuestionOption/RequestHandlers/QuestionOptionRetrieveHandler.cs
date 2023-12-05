using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.QuestionBank.QuestionOptionRow>;
using MyRow = GXpert.QuestionBank.QuestionOptionRow;

namespace GXpert.QuestionBank;

public interface IQuestionOptionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionOptionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionOptionRetrieveHandler
{
    public QuestionOptionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}