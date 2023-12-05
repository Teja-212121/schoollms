import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentRow } from "./ContentRow";

export namespace ContentService {
    export const baseUrl = 'Content/Content';

    export declare function Create(request: SaveRequest<ContentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentRow>>;

    export const Methods = {
        Create: "Content/Content/Create",
        Update: "Content/Content/Update",
        Delete: "Content/Content/Delete",
        Retrieve: "Content/Content/Retrieve",
        List: "Content/Content/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}