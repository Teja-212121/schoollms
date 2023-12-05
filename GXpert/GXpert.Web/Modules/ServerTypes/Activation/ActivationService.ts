import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ActivationRow } from "./ActivationRow";

export namespace ActivationService {
    export const baseUrl = 'Activation/Activation';

    export declare function Create(request: SaveRequest<ActivationRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ActivationRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ActivationRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ActivationRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ActivationRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ActivationRow>>;

    export const Methods = {
        Create: "Activation/Activation/Create",
        Update: "Activation/Activation/Update",
        Delete: "Activation/Activation/Delete",
        Retrieve: "Activation/Activation/Retrieve",
        List: "Activation/Activation/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ActivationService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}