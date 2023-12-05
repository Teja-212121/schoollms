using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Exams.ExamQuestionRow>;
using MyRow = GXpert.Exams.ExamQuestionRow;

namespace GXpert.Exams;

public interface IExamQuestionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ExamQuestionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionRetrieveHandler
{
    public ExamQuestionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}