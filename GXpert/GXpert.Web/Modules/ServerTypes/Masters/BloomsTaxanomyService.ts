import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { BloomsTaxanomyRow } from "./BloomsTaxanomyRow";

export namespace BloomsTaxanomyService {
    export const baseUrl = 'Masters/BloomsTaxanomy';

    export declare function Create(request: SaveRequest<BloomsTaxanomyRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<BloomsTaxanomyRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BloomsTaxanomyRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<BloomsTaxanomyRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<BloomsTaxanomyRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<BloomsTaxanomyRow>>;

    export const Methods = {
        Create: "Masters/BloomsTaxanomy/Create",
        Update: "Masters/BloomsTaxanomy/Update",
        Delete: "Masters/BloomsTaxanomy/Delete",
        Retrieve: "Masters/BloomsTaxanomy/Retrieve",
        List: "Masters/BloomsTaxanomy/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>BloomsTaxanomyService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}