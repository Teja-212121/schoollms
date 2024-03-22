import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { CourseRow } from "./CourseRow";

export namespace CourseService {
    export const baseUrl = 'Syllabus/Course';

    export declare function Create(request: SaveRequest<CourseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CourseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CourseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CourseRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CourseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CourseRow>>;

    export const Methods = {
        Create: "Syllabus/Course/Create",
        Update: "Syllabus/Course/Update",
        Delete: "Syllabus/Course/Delete",
        Retrieve: "Syllabus/Course/Retrieve",
        List: "Syllabus/Course/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CourseService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}