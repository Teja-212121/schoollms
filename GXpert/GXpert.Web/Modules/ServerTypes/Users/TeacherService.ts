import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { TeacherRow } from "./TeacherRow";

export namespace TeacherService {
    export const baseUrl = 'Users/Teacher';

    export declare function Create(request: SaveRequest<TeacherRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<TeacherRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TeacherRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<TeacherRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TeacherRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<TeacherRow>>;

    export const Methods = {
        Create: "Users/Teacher/Create",
        Update: "Users/Teacher/Update",
        Delete: "Users/Teacher/Delete",
        Retrieve: "Users/Teacher/Retrieve",
        List: "Users/Teacher/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>TeacherService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}