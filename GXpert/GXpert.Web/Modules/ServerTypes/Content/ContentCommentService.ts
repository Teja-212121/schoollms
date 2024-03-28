import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentCommentRow } from "./ContentCommentRow";

export namespace ContentCommentService {
    export const baseUrl = 'Content/ContentComment';

    export declare function Create(request: SaveRequest<ContentCommentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentCommentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentCommentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentCommentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentCommentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentCommentRow>>;

    export const Methods = {
        Create: "Content/ContentComment/Create",
        Update: "Content/ContentComment/Update",
        Delete: "Content/ContentComment/Delete",
        Retrieve: "Content/ContentComment/Retrieve",
        List: "Content/ContentComment/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentCommentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}