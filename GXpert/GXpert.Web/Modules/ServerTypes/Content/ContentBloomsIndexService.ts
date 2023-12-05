import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentBloomsIndexRow } from "./ContentBloomsIndexRow";

export namespace ContentBloomsIndexService {
    export const baseUrl = 'Content/ContentBloomsIndex';

    export declare function Create(request: SaveRequest<ContentBloomsIndexRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentBloomsIndexRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentBloomsIndexRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentBloomsIndexRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentBloomsIndexRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentBloomsIndexRow>>;

    export const Methods = {
        Create: "Content/ContentBloomsIndex/Create",
        Update: "Content/ContentBloomsIndex/Update",
        Delete: "Content/ContentBloomsIndex/Delete",
        Retrieve: "Content/ContentBloomsIndex/Retrieve",
        List: "Content/ContentBloomsIndex/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentBloomsIndexService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}