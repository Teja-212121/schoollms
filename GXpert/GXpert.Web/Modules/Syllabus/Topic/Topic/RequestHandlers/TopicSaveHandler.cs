using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Syllabus.TopicRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Syllabus.TopicRow;

namespace GXpert.Syllabus;

public interface ITopicSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class TopicSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITopicSaveHandler
{
    public TopicSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}