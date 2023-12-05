import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PlayListRow } from "./PlayListRow";

export namespace PlayListService {
    export const baseUrl = 'Playlist/PlayList';

    export declare function Create(request: SaveRequest<PlayListRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PlayListRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PlayListRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PlayListRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PlayListRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PlayListRow>>;

    export const Methods = {
        Create: "Playlist/PlayList/Create",
        Update: "Playlist/PlayList/Update",
        Delete: "Playlist/PlayList/Delete",
        Retrieve: "Playlist/PlayList/Retrieve",
        List: "Playlist/PlayList/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PlayListService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}