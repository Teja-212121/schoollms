import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SubjectRow } from "./SubjectRow";

export namespace SubjectService {
    export const baseUrl = 'Syllabus/Subject';

    export declare function Create(request: SaveRequest<SubjectRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SubjectRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SubjectRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SubjectRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SubjectRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SubjectRow>>;

    export const Methods = {
        Create: "Syllabus/Subject/Create",
        Update: "Syllabus/Subject/Update",
        Delete: "Syllabus/Subject/Delete",
        Retrieve: "Syllabus/Subject/Retrieve",
        List: "Syllabus/Subject/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SubjectService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}