import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { StudentRow } from "./StudentRow";

export namespace StudentService {
    export const baseUrl = 'Users/Student';

    export declare function Create(request: SaveRequest<StudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<StudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<StudentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<StudentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<StudentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<StudentRow>>;

    export const Methods = {
        Create: "Users/Student/Create",
        Update: "Users/Student/Update",
        Delete: "Users/Student/Delete",
        Retrieve: "Users/Student/Retrieve",
        List: "Users/Student/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>StudentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}