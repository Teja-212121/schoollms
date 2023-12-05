import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SchoolTeacherRow } from "./SchoolTeacherRow";

export namespace SchoolTeacherService {
    export const baseUrl = 'Schools/SchoolTeacher';

    export declare function Create(request: SaveRequest<SchoolTeacherRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SchoolTeacherRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SchoolTeacherRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SchoolTeacherRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SchoolTeacherRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SchoolTeacherRow>>;

    export const Methods = {
        Create: "Schools/SchoolTeacher/Create",
        Update: "Schools/SchoolTeacher/Update",
        Delete: "Schools/SchoolTeacher/Delete",
        Retrieve: "Schools/SchoolTeacher/Retrieve",
        List: "Schools/SchoolTeacher/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SchoolTeacherService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}