import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { InstituteRow } from "./InstituteRow";

export namespace InstituteService {
    export const baseUrl = 'Institute/Institute';

    export declare function Create(request: SaveRequest<InstituteRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<InstituteRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<InstituteRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<InstituteRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<InstituteRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<InstituteRow>>;

    export const Methods = {
        Create: "Institute/Institute/Create",
        Update: "Institute/Institute/Update",
        Delete: "Institute/Institute/Delete",
        Retrieve: "Institute/Institute/Retrieve",
        List: "Institute/Institute/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>InstituteService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}