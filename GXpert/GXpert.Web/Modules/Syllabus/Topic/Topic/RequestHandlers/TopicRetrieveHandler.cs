using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Syllabus.TopicRow>;
using MyRow = GXpert.Syllabus.TopicRow;

namespace GXpert.Syllabus;

public interface ITopicRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class TopicRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITopicRetrieveHandler
{
    public TopicRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}