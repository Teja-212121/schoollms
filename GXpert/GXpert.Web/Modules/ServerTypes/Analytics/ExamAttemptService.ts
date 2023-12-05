import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExamAttemptRow } from "./ExamAttemptRow";

export namespace ExamAttemptService {
    export const baseUrl = 'Analytics/ExamAttempt';

    export declare function Create(request: SaveRequest<ExamAttemptRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ExamAttemptRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ExamAttemptRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ExamAttemptRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ExamAttemptRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ExamAttemptRow>>;

    export const Methods = {
        Create: "Analytics/ExamAttempt/Create",
        Update: "Analytics/ExamAttempt/Update",
        Delete: "Analytics/ExamAttempt/Delete",
        Retrieve: "Analytics/ExamAttempt/Retrieve",
        List: "Analytics/ExamAttempt/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ExamAttemptService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}