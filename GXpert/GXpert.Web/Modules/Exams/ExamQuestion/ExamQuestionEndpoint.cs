using GXpert.QuestionBank;
using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = GXpert.Exams.ExamQuestionRow;

namespace GXpert.Exams.Endpoints;

[Route("Services/Exams/ExamQuestion/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class ExamQuestionEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IExamQuestionSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IExamQuestionSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IExamQuestionDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IExamQuestionRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IExamQuestionListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IExamQuestionListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.ExamQuestionColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "ExamQuestionList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }


    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse AssignExam(IUnitOfWork uow, SaveRequest<MyRow> request)
    {
        SaveResponse saveResponse = new SaveResponse();

        if (request.Entity.RowIds != null)
        {
            string[] rowIds = request.Entity.RowIds.Split(',');
            string erromsg = null;
            bool issingleadded = false;
            if (rowIds.Length > 0)
            {
                int i = 1;
                foreach (var id in rowIds)
                {
                    if (uow.Connection.Exists<MyRow>
                                (MyRow.Fields.ExamId == request.Entity.ExamId.Value &&
                                    MyRow.Fields.QuestionId == Convert.ToInt32(id)))
                    {
                        erromsg = erromsg + id + ",";
                    }
                    else
                    {
                        var Question = uow.Connection.TryFirst<QuestionRow>(QuestionRow.Fields.Id == Convert.ToInt32(id));
                        var QuestionOption = uow.Connection.TryFirst<QuestionOptionRow>(QuestionOptionRow.Fields.QuestionId == Convert.ToInt32(id));
                        var exam = uow.Connection.TryFirst<ExamRow>(ExamRow.Fields.Id == request.Entity.ExamId.Value);
                        var Id = uow.Connection.InsertAndGetID(new MyRow
                        {

                            QuestionId = Question.Id,
                            ExamId = request.Entity.ExamId.Value,
                            ExamSectionId = request.Entity.ExamSectionId.Value,
                            SortOrder = request.Entity.SortOrder,
                            Marks = request.Entity.Marks,

                            RightAnswer = QuestionOption.OptionText,
                            EDifficultyLevel = Question.EDifficultyLevel,
                            InsertDate = DateTime.Now,
                            InsertUserId = 1,
                            UpdateDate=DateTime.Now,
                            UpdateUserId=Convert.ToInt32(User.GetIdentifier()),
                            IsActive = true,
                        });
                        issingleadded = true;
                    }
                    i++;

                    if (issingleadded == false)
                    {
                        throw new ValidationError("already Mapped To ExamQuestions");

                    }
                    if (erromsg != null)
                    {
                        erromsg = "Exam Question with Id " + erromsg + " already Mapped To Exams.Other Questions Mapped To exam";
                        saveResponse.Error = new ServiceError();
                        saveResponse.Error.Message = erromsg;
                    }
                    else
                    {
                        saveResponse.Error = new ServiceError();
                        saveResponse.Error.Message = "Added Successfully";
                    }
                }
            }
        }
        return saveResponse;
    }
}
