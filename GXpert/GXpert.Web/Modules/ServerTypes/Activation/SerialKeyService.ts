import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SerialKeyRow } from "./SerialKeyRow";

export namespace SerialKeyService {
    export const baseUrl = 'Activation/SerialKey';

    export declare function Create(request: SaveRequest<SerialKeyRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SerialKeyRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SerialKeyRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SerialKeyRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SerialKeyRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SerialKeyRow>>;

    export const Methods = {
        Create: "Activation/SerialKey/Create",
        Update: "Activation/SerialKey/Update",
        Delete: "Activation/SerialKey/Delete",
        Retrieve: "Activation/SerialKey/Retrieve",
        List: "Activation/SerialKey/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SerialKeyService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}