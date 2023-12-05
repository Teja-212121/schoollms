using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Exams.ExamQuestionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Exams.ExamQuestionRow;

namespace GXpert.Exams;

public interface IExamQuestionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ExamQuestionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamQuestionSaveHandler
{
    public ExamQuestionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}