import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExcelImportResponse } from "@serenity-is/extensions";
import { PreAcademicScoreExcelImportRequest } from "./PreAcademicScoreExcelImportRequest";
import { PreAcademicScoreRow } from "./PreAcademicScoreRow";

export namespace PreAcademicScoreService {
    export const baseUrl = 'Masters/PreAcademicScore';

    export declare function Create(request: SaveRequest<PreAcademicScoreRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PreAcademicScoreRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PreAcademicScoreRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PreAcademicScoreRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PreAcademicScoreRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PreAcademicScoreRow>>;
    export declare function ExcelImport(request: PreAcademicScoreExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): PromiseLike<ExcelImportResponse>;

    export const Methods = {
        Create: "Masters/PreAcademicScore/Create",
        Update: "Masters/PreAcademicScore/Update",
        Delete: "Masters/PreAcademicScore/Delete",
        Retrieve: "Masters/PreAcademicScore/Retrieve",
        List: "Masters/PreAcademicScore/List",
        ExcelImport: "Masters/PreAcademicScore/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>PreAcademicScoreService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}