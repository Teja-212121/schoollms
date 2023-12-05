import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AssignmentRow } from "./AssignmentRow";

export namespace AssignmentService {
    export const baseUrl = 'Exams/Assignment';

    export declare function Create(request: SaveRequest<AssignmentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AssignmentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AssignmentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AssignmentRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AssignmentRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AssignmentRow>>;

    export const Methods = {
        Create: "Exams/Assignment/Create",
        Update: "Exams/Assignment/Update",
        Delete: "Exams/Assignment/Delete",
        Retrieve: "Exams/Assignment/Retrieve",
        List: "Exams/Assignment/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AssignmentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}