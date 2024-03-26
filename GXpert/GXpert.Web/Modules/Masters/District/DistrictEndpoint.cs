using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = GXpert.Masters.DistrictRow;

namespace GXpert.Masters.Endpoints;

[Route("Services/Masters/District/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class DistrictEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IDistrictSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IDistrictSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IDistrictDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IDistrictRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IDistrictListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IDistrictListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.DistrictColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "DistrictList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, DistrictExcelImportRequest request,
          [FromServices] IUploadStorage uploadStorage,
          [FromServices] IStateSaveHandler handler)
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

                string title = Convert.ToString(worksheet.Cells[row, 1].Value);
                if (string.IsNullOrEmpty(title))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Title Not found");
                    continue;
                }

                Row.Title = title;
                
                int? stateId = Convert.ToInt32(worksheet.Cells[row, 2].Value ?? null);
                if (stateId == 0)
                    stateId = null;
                if (stateId != null)
                {
                    var State = uow.Connection.TryFirst<StateRow>(StateRow.Fields.Id == stateId.Value);
                    if (State != null)
                    {
                        Row.StateId = State.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid StateId !");
                        continue;
                    }
                }

                string shortname = Convert.ToString(worksheet.Cells[row, 3].Value);
                if (string.IsNullOrEmpty(shortname))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Shortname Not found");
                    continue;
                }
                Row.ShortName = shortname;

                var district = new DistrictRow
                {
                    Title = Row.Title,
                    StateId=Row.StateId,
                    ShortName = Row.ShortName,
                    InsertDate = DateTime.Now,
                    InsertUserId = Convert.ToInt32(User.GetIdentifier())
                };
                uow.Connection.Insert<DistrictRow>(district);


                response.Inserted = response.Inserted + 1;
            }
            catch (Exception)
            {
                //response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
                throw;
            }
        }
        return response;
    }

    public class DistrictExcelImportRequest : ServiceRequest
    {
        public string FileName { get; set; }

    }
}