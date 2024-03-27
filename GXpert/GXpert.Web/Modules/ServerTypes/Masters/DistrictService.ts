import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExcelImportResponse } from "@serenity-is/extensions";
import { DistrictExcelImportRequest } from "./DistrictExcelImportRequest";
import { DistrictRow } from "./DistrictRow";

export namespace DistrictService {
    export const baseUrl = 'Masters/District';

    export declare function Create(request: SaveRequest<DistrictRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<DistrictRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DistrictRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<DistrictRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DistrictRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<DistrictRow>>;
    export declare function ExcelImport(request: DistrictExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): PromiseLike<ExcelImportResponse>;

    export const Methods = {
        Create: "Masters/District/Create",
        Update: "Masters/District/Update",
        Delete: "Masters/District/Delete",
        Retrieve: "Masters/District/Retrieve",
        List: "Masters/District/List",
        ExcelImport: "Masters/District/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>DistrictService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}