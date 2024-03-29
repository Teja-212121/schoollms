import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExamQuestionRow } from "./ExamQuestionRow";

export namespace ExamQuestionService {
    export const baseUrl = 'Exams/ExamQuestion';

    export declare function Create(request: SaveRequest<ExamQuestionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ExamQuestionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ExamQuestionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ExamQuestionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ExamQuestionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ExamQuestionRow>>;
    export declare function AssignExam(request: SaveRequest<ExamQuestionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;

    export const Methods = {
        Create: "Exams/ExamQuestion/Create",
        Update: "Exams/ExamQuestion/Update",
        Delete: "Exams/ExamQuestion/Delete",
        Retrieve: "Exams/ExamQuestion/Retrieve",
        List: "Exams/ExamQuestion/List",
        AssignExam: "Exams/ExamQuestion/AssignExam"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'AssignExam'
    ].forEach(x => {
        (<any>ExamQuestionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}