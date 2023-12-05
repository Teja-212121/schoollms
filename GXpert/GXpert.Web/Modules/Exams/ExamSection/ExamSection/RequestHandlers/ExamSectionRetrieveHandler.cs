using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Exams.ExamSectionRow>;
using MyRow = GXpert.Exams.ExamSectionRow;

namespace GXpert.Exams;

public interface IExamSectionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ExamSectionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionRetrieveHandler
{
    public ExamSectionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}