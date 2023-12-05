import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PlayListcontentRow } from "./PlayListcontentRow";

export namespace PlayListcontentService {
    export const baseUrl = 'Playlist/PlayListcontent';

    export declare function Create(request: SaveRequest<PlayListcontentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PlayListcontentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PlayListcontentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PlayListcontentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PlayListcontentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PlayListcontentRow>>;

    export const Methods = {
        Create: "Playlist/PlayListcontent/Create",
        Update: "Playlist/PlayListcontent/Update",
        Delete: "Playlist/PlayListcontent/Delete",
        Retrieve: "Playlist/PlayListcontent/Retrieve",
        List: "Playlist/PlayListcontent/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PlayListcontentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}