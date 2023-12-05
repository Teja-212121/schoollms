import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExamSectionRow } from "./ExamSectionRow";

export namespace ExamSectionService {
    export const baseUrl = 'Exams/ExamSection';

    export declare function Create(request: SaveRequest<ExamSectionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ExamSectionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ExamSectionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ExamSectionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ExamSectionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ExamSectionRow>>;

    export const Methods = {
        Create: "Exams/ExamSection/Create",
        Update: "Exams/ExamSection/Update",
        Delete: "Exams/ExamSection/Delete",
        Retrieve: "Exams/ExamSection/Retrieve",
        List: "Exams/ExamSection/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ExamSectionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}