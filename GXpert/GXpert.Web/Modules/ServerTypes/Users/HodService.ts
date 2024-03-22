import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { HodRow } from "./HodRow";

export namespace HodService {
    export const baseUrl = 'Users/Hod';

    export declare function Create(request: SaveRequest<HodRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<HodRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<HodRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<HodRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<HodRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<HodRow>>;

    export const Methods = {
        Create: "Users/Hod/Create",
        Update: "Users/Hod/Update",
        Delete: "Users/Hod/Delete",
        Retrieve: "Users/Hod/Retrieve",
        List: "Users/Hod/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>HodService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}