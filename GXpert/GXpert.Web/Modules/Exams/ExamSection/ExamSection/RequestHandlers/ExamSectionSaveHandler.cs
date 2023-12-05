using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Exams.ExamSectionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Exams.ExamSectionRow;

namespace GXpert.Exams;

public interface IExamSectionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ExamSectionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionSaveHandler
{
    public ExamSectionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}