import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AssignedExamTeachersRow } from "./AssignedExamTeachersRow";

export namespace AssignedExamTeachersService {
    export const baseUrl = 'Analytics/AssignedExamTeachers';

    export declare function Create(request: SaveRequest<AssignedExamTeachersRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AssignedExamTeachersRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AssignedExamTeachersRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AssignedExamTeachersRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AssignedExamTeachersRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AssignedExamTeachersRow>>;

    export const Methods = {
        Create: "Analytics/AssignedExamTeachers/Create",
        Update: "Analytics/AssignedExamTeachers/Update",
        Delete: "Analytics/AssignedExamTeachers/Delete",
        Retrieve: "Analytics/AssignedExamTeachers/Retrieve",
        List: "Analytics/AssignedExamTeachers/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AssignedExamTeachersService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}