import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentTopicRow } from "./ContentTopicRow";

export namespace ContentTopicService {
    export const baseUrl = 'Content/ContentTopic';

    export declare function Create(request: SaveRequest<ContentTopicRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentTopicRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentTopicRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentTopicRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentTopicRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentTopicRow>>;

    export const Methods = {
        Create: "Content/ContentTopic/Create",
        Update: "Content/ContentTopic/Update",
        Delete: "Content/ContentTopic/Delete",
        Retrieve: "Content/ContentTopic/Retrieve",
        List: "Content/ContentTopic/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentTopicService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}