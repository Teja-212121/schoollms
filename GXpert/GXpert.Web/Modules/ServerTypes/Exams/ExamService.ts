import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExamRow } from "./ExamRow";

export namespace ExamService {
    export const baseUrl = 'Exams/Exam';

    export declare function Create(request: SaveRequest<ExamRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ExamRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ExamRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ExamRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ExamRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ExamRow>>;

    export const Methods = {
        Create: "Exams/Exam/Create",
        Update: "Exams/Exam/Update",
        Delete: "Exams/Exam/Delete",
        Retrieve: "Exams/Exam/Retrieve",
        List: "Exams/Exam/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ExamService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}