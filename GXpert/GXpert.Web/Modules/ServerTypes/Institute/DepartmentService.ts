import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { DepartmentRow } from "./DepartmentRow";

export namespace DepartmentService {
    export const baseUrl = 'Institute/Department';

    export declare function Create(request: SaveRequest<DepartmentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<DepartmentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DepartmentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<DepartmentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DepartmentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<DepartmentRow>>;

    export const Methods = {
        Create: "Institute/Department/Create",
        Update: "Institute/Department/Update",
        Delete: "Institute/Department/Delete",
        Retrieve: "Institute/Department/Retrieve",
        List: "Institute/Department/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DepartmentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}