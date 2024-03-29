using GXpert.Content;
using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = GXpert.Playlist.PlayListContentRow;

namespace GXpert.Playlist.Endpoints;

[Route("Services/Playlist/PlayListContent/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class PlayListContentEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IPlayListContentSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IPlayListContentSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IPlayListContentDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IPlayListContentRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IPlayListContentListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IPlayListContentListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.PlayListContentColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "PlayListContentList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse AssignPlaylist(IUnitOfWork uow, SaveRequest<MyRow> request)
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
                                (MyRow.Fields.PlayListId == request.Entity.PlayListId.Value &&
                                    MyRow.Fields.ContentId == id.ToString()))
                    {
                        erromsg = erromsg + id + ",";
                    }
                    else
                    {
                        var content = uow.Connection.TryFirst<ContentRow>(ContentRow.Fields.Id == id.ToString());

                        var Id = uow.Connection.InsertAndGetID(new MyRow
                        {
                           
                            ContentId = content.Id,
                            PlayListId = request.Entity.PlayListId.Value,
                            ExamId = request.Entity.ExamId.Value,
                            LiveSessionId = request.Entity.LiveSessionId.Value,
                            AssignmentId = request.Entity.AssignmentId.Value,
                            ModuleId = request.Entity.ModuleId.Value,
                            EContentType=request.Entity.EContentType.Value,
                            EPublishStatus = request.Entity.EPublishStatus.Value,
                            SortOrder =request.Entity.SortOrder.Value,
                            InsertDate = DateTime.Now,
                            InsertUserId = 1,
                            IsActive = true,
                        });
                        issingleadded = true;
                    }
                    i++;
                }
                if (issingleadded == false)
                {
                    throw new ValidationError("already Mapped To Playlist");

                }
                if (erromsg != null)
                {
                    erromsg = "Playlist with Id " + erromsg + " already Mapped To Content Media.Other Content Media Mapped To Playlist";
                    saveResponse.Error = new ServiceError();
                    saveResponse.Error.Message = erromsg;
                    //throw new ValidationError(erromsg);
                }
                else
                {
                    saveResponse.Error = new ServiceError();
                    saveResponse.Error.Message = "Added Successfully";
                }
            }
        }
        return saveResponse;
    }
}