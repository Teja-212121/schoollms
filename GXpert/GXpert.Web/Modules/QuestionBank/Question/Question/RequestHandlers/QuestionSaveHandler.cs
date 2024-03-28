using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.QuestionBank.QuestionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.QuestionBank.QuestionRow;

namespace GXpert.QuestionBank;

public interface IQuestionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }


public class QuestionSaveHandler(IRequestContext context) : SaveRequestHandler<MyRow, MyRequest, MyResponse>(context), IQuestionSaveHandler
{
    private static MyRow.RowFields Fld { get { return MyRow.Fields; } }

    protected override void BeforeSave()
    {
        base.BeforeSave();

        if (Row.QuestionText.StartsWith("<p>"))
        {
            string removeString = "<p>";
            int index = Row.QuestionText.IndexOf(removeString);
            Row.QuestionText = (index < 0)
                ? Row.QuestionText
                : Row.QuestionText.Remove(index, removeString.Length);
        }

        if (Row.QuestionText.EndsWith("</p>"))
        {
            string removeString = "</p>";
            int index = Row.QuestionText.LastIndexOf(removeString);
            Row.QuestionText = Row.QuestionText.Substring(0, index);
        }

        if (Row.Explaination == null)
        {
            Row.Explaination = null;
        }
        else
        {
            if (Row.Explaination.StartsWith("<p>"))
            {
                string removeString = "<p>";
                int index = Row.Explaination.IndexOf(removeString);
                Row.Explaination = (index < 0)
                    ? Row.Explaination
                    : Row.Explaination.Remove(index, removeString.Length);
            }

            if (Row.Explaination.EndsWith("</p>"))
            {
                string removeString = "</p>";
                int index = Row.Explaination.LastIndexOf(removeString);
                Row.Explaination = Row.Explaination.Substring(0, index);
            }
        }
    }

    protected override void AfterSave()
    {
        base.AfterSave();
        if (IsUpdate)
        { }
        Cache.InvalidateOnCommit(UnitOfWork, Fld);
    }
    protected override void ExecuteSave()
    {
        base.ExecuteSave();
    }
}