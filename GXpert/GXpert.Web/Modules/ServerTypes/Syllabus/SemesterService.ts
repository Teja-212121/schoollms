import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SemesterRow } from "./SemesterRow";

export namespace SemesterService {
    export const baseUrl = 'Syllabus/Semester';

    export declare function Create(request: SaveRequest<SemesterRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SemesterRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SemesterRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SemesterRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SemesterRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SemesterRow>>;

    export const Methods = {
        Create: "Syllabus/Semester/Create",
        Update: "Syllabus/Semester/Update",
        Delete: "Syllabus/Semester/Delete",
        Retrieve: "Syllabus/Semester/Retrieve",
        List: "Syllabus/Semester/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SemesterService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}