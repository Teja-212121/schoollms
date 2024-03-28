import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentLicenseRow } from "./ContentLicenseRow";

export namespace ContentLicenseService {
    export const baseUrl = 'Content/ContentLicense';

    export declare function Create(request: SaveRequest<ContentLicenseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentLicenseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentLicenseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentLicenseRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentLicenseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentLicenseRow>>;

    export const Methods = {
        Create: "Content/ContentLicense/Create",
        Update: "Content/ContentLicense/Update",
        Delete: "Content/ContentLicense/Delete",
        Retrieve: "Content/ContentLicense/Retrieve",
        List: "Content/ContentLicense/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentLicenseService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}