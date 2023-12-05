import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ModuleRow } from "./ModuleRow";

export namespace ModuleService {
    export const baseUrl = 'Playlist/Module';

    export declare function Create(request: SaveRequest<ModuleRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ModuleRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ModuleRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ModuleRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ModuleRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ModuleRow>>;

    export const Methods = {
        Create: "Playlist/Module/Create",
        Update: "Playlist/Module/Update",
        Delete: "Playlist/Module/Delete",
        Retrieve: "Playlist/Module/Retrieve",
        List: "Playlist/Module/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ModuleService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}