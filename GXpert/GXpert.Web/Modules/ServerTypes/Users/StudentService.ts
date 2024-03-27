import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExcelImportResponse } from "@serenity-is/extensions";
import { StudentExcelImportRequest } from "./StudentExcelImportRequest";
import { StudentRow } from "./StudentRow";

export namespace StudentService {
    export const baseUrl = 'Users/Student';

    export declare function Create(request: SaveRequest<StudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<StudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<StudentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<StudentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<StudentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<StudentRow>>;
    export declare function ExcelImport(request: StudentExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): PromiseLike<ExcelImportResponse>;

    export const Methods = {
        Create: "Users/Student/Create",
        Update: "Users/Student/Update",
        Delete: "Users/Student/Delete",
        Retrieve: "Users/Student/Retrieve",
        List: "Users/Student/List",
        ExcelImport: "Users/Student/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>StudentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}