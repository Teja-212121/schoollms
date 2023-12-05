using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Exams.ExamRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Exams.ExamRow;

namespace GXpert.Exams;

public interface IExamSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ExamSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSaveHandler
{
    public ExamSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}