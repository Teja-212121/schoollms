import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { BranchRow } from "./BranchRow";

export namespace BranchService {
    export const baseUrl = 'Institute/Branch';

    export declare function Create(request: SaveRequest<BranchRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<BranchRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BranchRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<BranchRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<BranchRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<BranchRow>>;

    export const Methods = {
        Create: "Institute/Branch/Create",
        Update: "Institute/Branch/Update",
        Delete: "Institute/Branch/Delete",
        Retrieve: "Institute/Branch/Retrieve",
        List: "Institute/Branch/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>BranchService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}