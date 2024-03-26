import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExcelImportResponse } from "@serenity-is/extensions";
import { TalukaExcelImportRequest } from "./TalukaExcelImportRequest";
import { TalukaRow } from "./TalukaRow";

export namespace TalukaService {
    export const baseUrl = 'Masters/Taluka';

    export declare function Create(request: SaveRequest<TalukaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<TalukaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TalukaRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<TalukaRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TalukaRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<TalukaRow>>;
    export declare function ExcelImport(request: TalukaExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): PromiseLike<ExcelImportResponse>;

    export const Methods = {
        Create: "Masters/Taluka/Create",
        Update: "Masters/Taluka/Update",
        Delete: "Masters/Taluka/Delete",
        Retrieve: "Masters/Taluka/Retrieve",
        List: "Masters/Taluka/List",
        ExcelImport: "Masters/Taluka/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>TalukaService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}