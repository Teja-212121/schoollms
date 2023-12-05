import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { QuestionRow } from "./QuestionRow";

export namespace QuestionService {
    export const baseUrl = 'QuestionBank/Question';

    export declare function Create(request: SaveRequest<QuestionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<QuestionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<QuestionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<QuestionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<QuestionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<QuestionRow>>;

    export const Methods = {
        Create: "QuestionBank/Question/Create",
        Update: "QuestionBank/Question/Update",
        Delete: "QuestionBank/Question/Delete",
        Retrieve: "QuestionBank/Question/Retrieve",
        List: "QuestionBank/Question/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>QuestionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}