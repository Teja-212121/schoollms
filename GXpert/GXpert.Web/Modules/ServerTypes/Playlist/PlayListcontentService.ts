import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PlayListContentRow } from "./PlayListContentRow";

export namespace PlayListContentService {
    export const baseUrl = 'Playlist/PlayListContent';

    export declare function Create(request: SaveRequest<PlayListContentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PlayListContentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PlayListContentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PlayListContentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PlayListContentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PlayListContentRow>>;

    export const Methods = {
        Create: "Playlist/PlayListContent/Create",
        Update: "Playlist/PlayListContent/Update",
        Delete: "Playlist/PlayListContent/Delete",
        Retrieve: "Playlist/PlayListContent/Retrieve",
        List: "Playlist/PlayListContent/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PlayListContentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}