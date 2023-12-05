using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Exams.ExamQuestionRow>;
using MyRow = GXpert.Exams.ExamQuestionRow;

namespace GXpert.Exams;

public interface IExamQuestionListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ExamQuestionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionListHandler
{
    public ExamQuestionListHandler(IRequestContext context)
            : base(context)
    {
    }
}