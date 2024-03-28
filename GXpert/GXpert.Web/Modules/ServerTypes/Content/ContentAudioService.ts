import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentAudioRow } from "./ContentAudioRow";

export namespace ContentAudioService {
    export const baseUrl = 'Content/ContentAudio';

    export declare function Create(request: SaveRequest<ContentAudioRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentAudioRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentAudioRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentAudioRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentAudioRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentAudioRow>>;

    export const Methods = {
        Create: "Content/ContentAudio/Create",
        Update: "Content/ContentAudio/Update",
        Delete: "Content/ContentAudio/Delete",
        Retrieve: "Content/ContentAudio/Retrieve",
        List: "Content/ContentAudio/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentAudioService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}