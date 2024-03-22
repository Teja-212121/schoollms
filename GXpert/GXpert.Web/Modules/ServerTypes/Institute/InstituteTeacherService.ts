import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { InstituteTeacherRow } from "./InstituteTeacherRow";

export namespace InstituteTeacherService {
    export const baseUrl = 'Institute/InstituteTeacher';

    export declare function Create(request: SaveRequest<InstituteTeacherRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<InstituteTeacherRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<InstituteTeacherRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<InstituteTeacherRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<InstituteTeacherRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<InstituteTeacherRow>>;

    export const Methods = {
        Create: "Institute/InstituteTeacher/Create",
        Update: "Institute/InstituteTeacher/Update",
        Delete: "Institute/InstituteTeacher/Delete",
        Retrieve: "Institute/InstituteTeacher/Retrieve",
        List: "Institute/InstituteTeacher/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>InstituteTeacherService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}