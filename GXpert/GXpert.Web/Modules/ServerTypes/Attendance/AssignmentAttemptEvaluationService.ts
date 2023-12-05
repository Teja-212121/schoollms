import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AssignmentAttemptEvaluationRow } from "./AssignmentAttemptEvaluationRow";

export namespace AssignmentAttemptEvaluationService {
    export const baseUrl = 'Attendance/AssignmentAttemptEvaluation';

    export declare function Create(request: SaveRequest<AssignmentAttemptEvaluationRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AssignmentAttemptEvaluationRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AssignmentAttemptEvaluationRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AssignmentAttemptEvaluationRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AssignmentAttemptEvaluationRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AssignmentAttemptEvaluationRow>>;

    export const Methods = {
        Create: "Attendance/AssignmentAttemptEvaluation/Create",
        Update: "Attendance/AssignmentAttemptEvaluation/Update",
        Delete: "Attendance/AssignmentAttemptEvaluation/Delete",
        Retrieve: "Attendance/AssignmentAttemptEvaluation/Retrieve",
        List: "Attendance/AssignmentAttemptEvaluation/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AssignmentAttemptEvaluationService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}