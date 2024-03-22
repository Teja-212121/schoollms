import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PrincipalRow } from "./PrincipalRow";

export namespace PrincipalService {
    export const baseUrl = 'Users/Principal';

    export declare function Create(request: SaveRequest<PrincipalRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PrincipalRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PrincipalRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PrincipalRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PrincipalRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PrincipalRow>>;

    export const Methods = {
        Create: "Users/Principal/Create",
        Update: "Users/Principal/Update",
        Delete: "Users/Principal/Delete",
        Retrieve: "Users/Principal/Retrieve",
        List: "Users/Principal/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PrincipalService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}