import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentCourseRow } from "./ContentCourseRow";

export namespace ContentCourseService {
    export const baseUrl = 'Content/ContentCourse';

    export declare function Create(request: SaveRequest<ContentCourseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentCourseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentCourseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentCourseRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentCourseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentCourseRow>>;

    export const Methods = {
        Create: "Content/ContentCourse/Create",
        Update: "Content/ContentCourse/Update",
        Delete: "Content/ContentCourse/Delete",
        Retrieve: "Content/ContentCourse/Retrieve",
        List: "Content/ContentCourse/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentCourseService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}