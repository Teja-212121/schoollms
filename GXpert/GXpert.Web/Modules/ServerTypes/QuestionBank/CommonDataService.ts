import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { CommonDataRow } from "./CommonDataRow";

export namespace CommonDataService {
    export const baseUrl = 'QuestionBank/CommonData';

    export declare function Create(request: SaveRequest<CommonDataRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CommonDataRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CommonDataRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CommonDataRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CommonDataRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CommonDataRow>>;

    export const Methods = {
        Create: "QuestionBank/CommonData/Create",
        Update: "QuestionBank/CommonData/Update",
        Delete: "QuestionBank/CommonData/Delete",
        Retrieve: "QuestionBank/CommonData/Retrieve",
        List: "QuestionBank/CommonData/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CommonDataService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}