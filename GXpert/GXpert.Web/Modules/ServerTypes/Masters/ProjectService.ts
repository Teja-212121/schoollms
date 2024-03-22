import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ProjectRow } from "./ProjectRow";

export namespace ProjectService {
    export const baseUrl = 'Masters/Project';

    export declare function Create(request: SaveRequest<ProjectRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ProjectRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProjectRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ProjectRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProjectRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ProjectRow>>;

    export const Methods = {
        Create: "Masters/Project/Create",
        Update: "Masters/Project/Update",
        Delete: "Masters/Project/Delete",
        Retrieve: "Masters/Project/Retrieve",
        List: "Masters/Project/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ProjectService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}