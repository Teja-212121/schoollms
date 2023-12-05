using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Exams.ExamSectionRow>;
using MyRow = GXpert.Exams.ExamSectionRow;

namespace GXpert.Exams;

public interface IExamSectionListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ExamSectionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionListHandler
{
    public ExamSectionListHandler(IRequestContext context)
            : base(context)
    {
    }
}