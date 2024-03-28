using GXpert.Syllabus;
using GXpert.Users;
using GXpert.Web.Enums;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = GXpert.QuestionBank.QuestionRow;

namespace GXpert.QuestionBank.Endpoints;

[Route("Services/QuestionBank/Question/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class QuestionEndpoint : ServiceEndpoint
{
    public object EDifficultyLevels { get; private set; }
    public object EQuestionTypes { get; private set; }
    public object QuestionCommonDataRow { get; private set; }
    public long? QuestionId { get; private set; }

    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IQuestionSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IQuestionSaveHandler handler)
    {
        return handler.Update(uow, request);
    }

    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IQuestionDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IQuestionRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IQuestionListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IQuestionListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.QuestionColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "QuestionList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
          [FromServices] IUploadStorage uploadStorage,
          [FromServices] IQuestionSaveHandler handler)
    {
        if (request is null)
            throw new ArgumentNullException(nameof(request));
        if (string.IsNullOrWhiteSpace(request.FileName))
            throw new ArgumentNullException(nameof(request.FileName));

        if (uploadStorage is null)
            throw new ArgumentNullException(nameof(uploadStorage));

        UploadPathHelper.CheckFileNameSecurity(request.FileName);

        if (!request.FileName.StartsWith("temporary/", StringComparison.OrdinalIgnoreCase))
            throw new ArgumentOutOfRangeException(nameof(request.FileName));

        ExcelPackage ep = new();
        using (var fs = uploadStorage.OpenFile(request.FileName))
            ep.Load(fs);

        var p = MyRow.Fields;
        //var p = ProductsRow.Fields;

        var response = new ExcelImportResponse
        {
            ErrorList = new List<string>()
        };

        var worksheet = ep.Workbook.Worksheets[0];


        for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
        {
            try
             {
                MyRow Row = new MyRow();

                string QuestionText = Convert.ToString(worksheet.Cells[row, 1].Value);
                if (string.IsNullOrEmpty(QuestionText))
                {
                    response.ErrorList.Add("Error On Row " + row + ": QuestionText Not found");
                    continue;
                }
                Row.QuestionText=QuestionText;
                
                int? eQuestionType = Convert.ToInt32(worksheet.Cells[row, 2].Value ?? null);
                if (eQuestionType != null)
                {

                   // if (eQuestionType > 0 && eQuestionType < 3)
                    
                        if (eQuestionType == 1)
                            Row.EQuestionType = Web.Enums.EQuestionType.SINGLE_RIGHT_ANSWER;
                        else if (eQuestionType == 2)
                            Row.EQuestionType = Web.Enums.EQuestionType.MULTIPLE_RIGHT_ANSWER;
                        else if (eQuestionType == 3)
                            Row.EQuestionType = Web.Enums.EQuestionType.NUMERICAL;
                        else if (eQuestionType == 4)
                            Row.EQuestionType = Web.Enums.EQuestionType.TRUE_OR_FALSE;
                    
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid Question Type !");
                        continue;
                    }

                    int? Difficulty = Convert.ToInt32(worksheet.Cells[row, 3].Value ?? null);
                    if (Difficulty != null)
                    {
                        if (Difficulty > 0)
                        {
                            if (Difficulty == 1)
                                Row.EDifficultyLevel = Web.Enums.EDifficultyLevel.EASY;
                            if (Difficulty == 5)
                                Row.EDifficultyLevel = Web.Enums.EDifficultyLevel.MODERATE;
                            if (Difficulty == 10)
                                Row.EDifficultyLevel = Web.Enums.EDifficultyLevel.DIFFICULT;
                            if (Difficulty == 11)
                                Row.EDifficultyLevel = Web.Enums.EDifficultyLevel.MULTIPLE_RIGHT_ANSWER;
                        }
                        else
                        {
                            response.ErrorList.Add("Error On Row " + row + ":Invalid Difficulty Level !");
                            continue;
                        }
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Difficulty Level not Found!");
                        continue;
                    }
                    Row.ClassId = Convert.ToInt32(worksheet.Cells[row, 4].Value ?? null);
                    Row.SubjectId = Convert.ToInt32(worksheet.Cells[row, 5].Value ?? null);
                    Row.BloomsIndex = Convert.ToInt32(worksheet.Cells[row, 6].Value ?? null);

                }
                Row.IsActive = true;
                Row.InsertDate = DateTime.UtcNow;
                Row.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                uow.Connection.Insert(Row);
                response.Inserted = response.Inserted + 1;

                long? QuestionId = uow.Connection.InsertAndGetID<MyRow>(Row);

                string[] coroption = new string[] { };
                //string Note = "";
                List<QuestionOptionRow> OptionList = new List<QuestionOptionRow>();
                if (Row.EQuestionType == Web.Enums.EQuestionType.SINGLE_RIGHT_ANSWER || Row.EQuestionType == Web.Enums.EQuestionType.MULTIPLE_RIGHT_ANSWER)
                {
                    for (int j = 8; j < 13; j++)
                    {
                        var Questionoption = new QuestionOptionRow();
                        if (j < 11)
                        {
                            string option = Convert.ToString(worksheet.Cells[row, j].Value ?? "").Trim();
                            if (!string.IsNullOrEmpty(option))
                            {
                                Questionoption.OptionText = option;
                                OptionList.Add(Questionoption);
                            }
                            else
                            {
                                response.ErrorList.Add("Error On Row " + row + ": Atleast 2 options are Required!");
                                continue;
                            }
                        }
                        else
                        {
                            string option = Convert.ToString(worksheet.Cells[row, j].Value ?? "").Trim();
                            if (!string.IsNullOrEmpty(option))
                            {
                                Questionoption.OptionText = option;
                                OptionList.Add(Questionoption);
                            }
                        }

                        //Note = Convert.ToString(worksheet.Cells[row, 13].Value);
                        //if (!string.IsNullOrEmpty(Note))
                        //{
                        //    Questionoption.Notes = Note;
                        //}
                    }

                    string CorrectOption = Convert.ToString(worksheet.Cells[row, 13].Value ?? "").Trim();

                    if (!string.IsNullOrEmpty(CorrectOption))
                    {
                        coroption = CorrectOption.Split(",");
                    }
                }

                if (Row.EQuestionType == Web.Enums.EQuestionType.SINGLE_RIGHT_ANSWER || Row.EQuestionType == 
                        Web.Enums.EQuestionType.MULTIPLE_RIGHT_ANSWER)
                {
                    for (int c = 1; c <= OptionList.Count; c++)
                    {
                        bool isright = false;
                        if (coroption.Contains(c.ToString()))
                            isright = true;
                        uow.Connection.Insert(new QuestionOptionRow
                        {
                            QuestionId = QuestionId,
                            OptionText = OptionList[c - 1].OptionText,
                            IsCorrect = isright,
                            IsActive = true,
                            InsertDate = DateTime.Now,
                            
                            SortOrder = c,
                            //Notes = Note,
                            InsertUserId = Convert.ToInt32(User.GetIdentifier())
                        });
                    }
                }

            }
            catch (Exception)
            {
                //response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
                throw;
            }
        }
        return response;
    }
    public class QuestionExcelImportRequest : ServiceRequest
    {
        public string FileName { get; set; }

    }
}



