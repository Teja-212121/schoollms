import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { CouponCodeRow } from "./CouponCodeRow";

export namespace CouponCodeService {
    export const baseUrl = 'Activation/CouponCode';

    export declare function Create(request: SaveRequest<CouponCodeRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CouponCodeRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CouponCodeRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CouponCodeRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CouponCodeRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CouponCodeRow>>;

    export const Methods = {
        Create: "Activation/CouponCode/Create",
        Update: "Activation/CouponCode/Update",
        Delete: "Activation/CouponCode/Delete",
        Retrieve: "Activation/CouponCode/Retrieve",
        List: "Activation/CouponCode/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CouponCodeService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}