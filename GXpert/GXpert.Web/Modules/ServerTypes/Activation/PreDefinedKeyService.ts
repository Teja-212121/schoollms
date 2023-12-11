import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PreDefinedKeyRow } from "./PreDefinedKeyRow";

export namespace PreDefinedKeyService {
    export const baseUrl = 'Activation/PreDefinedKey';

    export declare function Create(request: SaveRequest<PreDefinedKeyRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PreDefinedKeyRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PreDefinedKeyRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PreDefinedKeyRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PreDefinedKeyRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PreDefinedKeyRow>>;

    export const Methods = {
        Create: "Activation/PreDefinedKey/Create",
        Update: "Activation/PreDefinedKey/Update",
        Delete: "Activation/PreDefinedKey/Delete",
        Retrieve: "Activation/PreDefinedKey/Retrieve",
        List: "Activation/PreDefinedKey/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PreDefinedKeyService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}