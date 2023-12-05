import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AssignmentEvaluationRow } from "./AssignmentEvaluationRow";

export namespace AssignmentEvaluationService {
    export const baseUrl = 'Exams/AssignmentEvaluation';

    export declare function Create(request: SaveRequest<AssignmentEvaluationRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AssignmentEvaluationRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AssignmentEvaluationRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AssignmentEvaluationRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AssignmentEvaluationRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AssignmentEvaluationRow>>;

    export const Methods = {
        Create: "Exams/AssignmentEvaluation/Create",
        Update: "Exams/AssignmentEvaluation/Update",
        Delete: "Exams/AssignmentEvaluation/Delete",
        Retrieve: "Exams/AssignmentEvaluation/Retrieve",
        List: "Exams/AssignmentEvaluation/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AssignmentEvaluationService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}