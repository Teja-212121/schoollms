import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExamAttemptQuestionRow } from "./ExamAttemptQuestionRow";

export namespace ExamAttemptQuestionService {
    export const baseUrl = 'Analytics/ExamAttemptQuestion';

    export declare function Create(request: SaveRequest<ExamAttemptQuestionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ExamAttemptQuestionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ExamAttemptQuestionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ExamAttemptQuestionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ExamAttemptQuestionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ExamAttemptQuestionRow>>;

    export const Methods = {
        Create: "Analytics/ExamAttemptQuestion/Create",
        Update: "Analytics/ExamAttemptQuestion/Update",
        Delete: "Analytics/ExamAttemptQuestion/Delete",
        Retrieve: "Analytics/ExamAttemptQuestion/Retrieve",
        List: "Analytics/ExamAttemptQuestion/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ExamAttemptQuestionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}