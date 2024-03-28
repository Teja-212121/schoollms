using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.QuestionBank.QuestionCourseRow>;
using MyRow = GXpert.QuestionBank.QuestionCourseRow;

namespace GXpert.QuestionBank;

public interface IQuestionCourseListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionCourseListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionCourseListHandler
{
    public QuestionCourseListHandler(IRequestContext context)
            : base(context)
    {
    }
}