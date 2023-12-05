using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Syllabus.TopicRow>;
using MyRow = GXpert.Syllabus.TopicRow;

namespace GXpert.Syllabus;

public interface ITopicListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class TopicListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITopicListHandler
{
    public TopicListHandler(IRequestContext context)
            : base(context)
    {
    }
}