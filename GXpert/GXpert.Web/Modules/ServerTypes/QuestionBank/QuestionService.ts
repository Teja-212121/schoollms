import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";
import { QuestionRow } from "./QuestionRow";

export namespace QuestionService {
    export const baseUrl = 'QuestionBank/Question';

    export declare function Create(request: SaveRequest<QuestionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<QuestionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<QuestionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<QuestionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<QuestionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<QuestionRow>>;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): PromiseLike<ExcelImportResponse>;

    export const Methods = {
        Create: "QuestionBank/Question/Create",
        Update: "QuestionBank/Question/Update",
        Delete: "QuestionBank/Question/Delete",
        Retrieve: "QuestionBank/Question/Retrieve",
        List: "QuestionBank/Question/List",
        ExcelImport: "QuestionBank/Question/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>QuestionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}