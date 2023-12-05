using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Exams.ExamRow>;
using MyRow = GXpert.Exams.ExamRow;

namespace GXpert.Exams;

public interface IExamListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ExamListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamListHandler
{
    public ExamListHandler(IRequestContext context)
            : base(context)
    {
    }
}