import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AssignmentAttemptRow } from "./AssignmentAttemptRow";

export namespace AssignmentAttemptService {
    export const baseUrl = 'Attendance/AssignmentAttempt';

    export declare function Create(request: SaveRequest<AssignmentAttemptRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AssignmentAttemptRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AssignmentAttemptRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AssignmentAttemptRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AssignmentAttemptRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AssignmentAttemptRow>>;

    export const Methods = {
        Create: "Attendance/AssignmentAttempt/Create",
        Update: "Attendance/AssignmentAttempt/Update",
        Delete: "Attendance/AssignmentAttempt/Delete",
        Retrieve: "Attendance/AssignmentAttempt/Retrieve",
        List: "Attendance/AssignmentAttempt/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AssignmentAttemptService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}