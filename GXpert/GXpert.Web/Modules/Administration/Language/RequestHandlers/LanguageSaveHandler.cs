using MyRequest = Serenity.Services.SaveRequest<GXpert.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Administration.LanguageRow;

namespace GXpert.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, MyRequest, MyResponse>(context), ILanguageSaveHandler
{
}