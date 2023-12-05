using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Exams.ExamRow>;
using MyRow = GXpert.Exams.ExamRow;

namespace GXpert.Exams;

public interface IExamRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ExamRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamRetrieveHandler
{
    public ExamRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}