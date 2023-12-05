import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ActivationLogRow } from "./ActivationLogRow";

export namespace ActivationLogService {
    export const baseUrl = 'Activation/ActivationLog';

    export declare function Create(request: SaveRequest<ActivationLogRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ActivationLogRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ActivationLogRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ActivationLogRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ActivationLogRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ActivationLogRow>>;

    export const Methods = {
        Create: "Activation/ActivationLog/Create",
        Update: "Activation/ActivationLog/Update",
        Delete: "Activation/ActivationLog/Delete",
        Retrieve: "Activation/ActivationLog/Retrieve",
        List: "Activation/ActivationLog/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ActivationLogService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}