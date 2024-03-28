import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentSubtitleRow } from "./ContentSubtitleRow";

export namespace ContentSubtitleService {
    export const baseUrl = 'Content/ContentSubtitle';

    export declare function Create(request: SaveRequest<ContentSubtitleRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentSubtitleRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentSubtitleRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentSubtitleRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentSubtitleRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentSubtitleRow>>;

    export const Methods = {
        Create: "Content/ContentSubtitle/Create",
        Update: "Content/ContentSubtitle/Update",
        Delete: "Content/ContentSubtitle/Delete",
        Retrieve: "Content/ContentSubtitle/Retrieve",
        List: "Content/ContentSubtitle/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentSubtitleService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}