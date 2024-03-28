using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.QuestionBank.QuestionCourseRow>;
using MyRow = GXpert.QuestionBank.QuestionCourseRow;

namespace GXpert.QuestionBank;

public interface IQuestionCourseRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionCourseRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionCourseRetrieveHandler
{
    public QuestionCourseRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}