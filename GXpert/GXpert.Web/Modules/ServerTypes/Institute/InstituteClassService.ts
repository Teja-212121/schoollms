import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { InstituteClassRow } from "./InstituteClassRow";

export namespace InstituteClassService {
    export const baseUrl = 'Institute/InstituteClass';

    export declare function Create(request: SaveRequest<InstituteClassRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<InstituteClassRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<InstituteClassRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<InstituteClassRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<InstituteClassRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<InstituteClassRow>>;

    export const Methods = {
        Create: "Institute/InstituteClass/Create",
        Update: "Institute/InstituteClass/Update",
        Delete: "Institute/InstituteClass/Delete",
        Retrieve: "Institute/InstituteClass/Retrieve",
        List: "Institute/InstituteClass/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>InstituteClassService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}