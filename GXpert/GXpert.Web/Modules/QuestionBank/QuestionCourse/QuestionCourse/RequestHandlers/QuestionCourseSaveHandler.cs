using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.QuestionBank.QuestionCourseRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.QuestionBank.QuestionCourseRow;

namespace GXpert.QuestionBank;

public interface IQuestionCourseSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class QuestionCourseSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionCourseSaveHandler
{
    public QuestionCourseSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}