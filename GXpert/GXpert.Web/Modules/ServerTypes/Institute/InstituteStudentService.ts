import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { InstituteStudentRow } from "./InstituteStudentRow";

export namespace InstituteStudentService {
    export const baseUrl = 'Institute/InstituteStudent';

    export declare function Create(request: SaveRequest<InstituteStudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<InstituteStudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<InstituteStudentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<InstituteStudentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<InstituteStudentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<InstituteStudentRow>>;

    export const Methods = {
        Create: "Institute/InstituteStudent/Create",
        Update: "Institute/InstituteStudent/Update",
        Delete: "Institute/InstituteStudent/Delete",
        Retrieve: "Institute/InstituteStudent/Retrieve",
        List: "Institute/InstituteStudent/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>InstituteStudentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}