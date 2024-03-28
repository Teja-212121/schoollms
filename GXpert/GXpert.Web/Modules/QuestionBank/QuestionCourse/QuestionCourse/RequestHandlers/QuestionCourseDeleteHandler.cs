using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.QuestionBank.QuestionCourseRow;

namespace GXpert.QuestionBank;

public interface IQuestionCourseDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionCourseDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionCourseDeleteHandler
{
    public QuestionCourseDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}