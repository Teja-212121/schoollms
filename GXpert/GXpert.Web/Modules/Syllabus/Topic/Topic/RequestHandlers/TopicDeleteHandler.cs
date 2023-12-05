using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Syllabus.TopicRow;

namespace GXpert.Syllabus;

public interface ITopicDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class TopicDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITopicDeleteHandler
{
    public TopicDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}