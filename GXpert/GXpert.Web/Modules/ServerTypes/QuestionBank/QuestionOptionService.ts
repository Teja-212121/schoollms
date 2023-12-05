import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { QuestionOptionRow } from "./QuestionOptionRow";

export namespace QuestionOptionService {
    export const baseUrl = 'QuestionBank/QuestionOption';

    export declare function Create(request: SaveRequest<QuestionOptionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<QuestionOptionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<QuestionOptionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<QuestionOptionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<QuestionOptionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<QuestionOptionRow>>;

    export const Methods = {
        Create: "QuestionBank/QuestionOption/Create",
        Update: "QuestionBank/QuestionOption/Update",
        Delete: "QuestionBank/QuestionOption/Delete",
        Retrieve: "QuestionBank/QuestionOption/Retrieve",
        List: "QuestionBank/QuestionOption/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>QuestionOptionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}