import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SchoolStudentRow } from "./SchoolStudentRow";

export namespace SchoolStudentService {
    export const baseUrl = 'Schools/SchoolStudent';

    export declare function Create(request: SaveRequest<SchoolStudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SchoolStudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SchoolStudentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SchoolStudentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SchoolStudentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SchoolStudentRow>>;

    export const Methods = {
        Create: "Schools/SchoolStudent/Create",
        Update: "Schools/SchoolStudent/Update",
        Delete: "Schools/SchoolStudent/Delete",
        Retrieve: "Schools/SchoolStudent/Retrieve",
        List: "Schools/SchoolStudent/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SchoolStudentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}