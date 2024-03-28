import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { QuestionCourseRow } from "./QuestionCourseRow";

export namespace QuestionCourseService {
    export const baseUrl = 'QuestionBank/QuestionCourse';

    export declare function Create(request: SaveRequest<QuestionCourseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<QuestionCourseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<QuestionCourseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<QuestionCourseRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<QuestionCourseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<QuestionCourseRow>>;

    export const Methods = {
        Create: "QuestionBank/QuestionCourse/Create",
        Update: "QuestionBank/QuestionCourse/Update",
        Delete: "QuestionBank/QuestionCourse/Delete",
        Retrieve: "QuestionBank/QuestionCourse/Retrieve",
        List: "QuestionBank/QuestionCourse/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>QuestionCourseService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}