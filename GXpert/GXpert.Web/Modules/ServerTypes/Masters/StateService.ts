import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { StateRow } from "./StateRow";

export namespace StateService {
    export const baseUrl = 'Masters/State';

    export declare function Create(request: SaveRequest<StateRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<StateRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<StateRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<StateRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<StateRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<StateRow>>;

    export const Methods = {
        Create: "Masters/State/Create",
        Update: "Masters/State/Update",
        Delete: "Masters/State/Delete",
        Retrieve: "Masters/State/Retrieve",
        List: "Masters/State/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>StateService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}