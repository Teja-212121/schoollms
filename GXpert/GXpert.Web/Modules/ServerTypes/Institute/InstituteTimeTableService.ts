import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";
import { InstituteTimeTableRow } from "./InstituteTimeTableRow";

export namespace InstituteTimeTableService {
    export const baseUrl = 'Institute/InstituteTimeTable';

    export declare function Create(request: SaveRequest<InstituteTimeTableRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<InstituteTimeTableRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<InstituteTimeTableRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<InstituteTimeTableRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<InstituteTimeTableRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<InstituteTimeTableRow>>;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): PromiseLike<ExcelImportResponse>;

    export const Methods = {
        Create: "Institute/InstituteTimeTable/Create",
        Update: "Institute/InstituteTimeTable/Update",
        Delete: "Institute/InstituteTimeTable/Delete",
        Retrieve: "Institute/InstituteTimeTable/Retrieve",
        List: "Institute/InstituteTimeTable/List",
        ExcelImport: "Institute/InstituteTimeTable/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>InstituteTimeTableService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}