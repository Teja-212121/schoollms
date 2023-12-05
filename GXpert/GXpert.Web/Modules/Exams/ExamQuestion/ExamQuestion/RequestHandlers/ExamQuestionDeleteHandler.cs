using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Exams.ExamQuestionRow;

namespace GXpert.Exams;

public interface IExamQuestionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ExamQuestionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionDeleteHandler
{
    public ExamQuestionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}