import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExcelImportResponse } from "@serenity-is/extensions";
import { AcademicperformanceExcelImportRequest } from "./AcademicperformanceExcelImportRequest";
import { AcademicPerformanceRow } from "./AcademicPerformanceRow";

export namespace AcademicPerformanceService {
    export const baseUrl = 'Masters/AcademicPerformance';

    export declare function Create(request: SaveRequest<AcademicPerformanceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AcademicPerformanceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AcademicPerformanceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AcademicPerformanceRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AcademicPerformanceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AcademicPerformanceRow>>;
    export declare function ExcelImport(request: AcademicperformanceExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): PromiseLike<ExcelImportResponse>;

    export const Methods = {
        Create: "Masters/AcademicPerformance/Create",
        Update: "Masters/AcademicPerformance/Update",
        Delete: "Masters/AcademicPerformance/Delete",
        Retrieve: "Masters/AcademicPerformance/Retrieve",
        List: "Masters/AcademicPerformance/List",
        ExcelImport: "Masters/AcademicPerformance/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>AcademicPerformanceService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}