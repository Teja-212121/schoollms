import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentCategoryRow } from "./ContentCategoryRow";

export namespace ContentCategoryService {
    export const baseUrl = 'Content/ContentCategory';

    export declare function Create(request: SaveRequest<ContentCategoryRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentCategoryRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentCategoryRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentCategoryRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentCategoryRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentCategoryRow>>;

    export const Methods = {
        Create: "Content/ContentCategory/Create",
        Update: "Content/ContentCategory/Update",
        Delete: "Content/ContentCategory/Delete",
        Retrieve: "Content/ContentCategory/Retrieve",
        List: "Content/ContentCategory/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentCategoryService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}