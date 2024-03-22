import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { UserAcademicRow } from "./UserAcademicRow";

export namespace UserAcademicService {
    export const baseUrl = 'Masters/UserAcademic';

    export declare function Create(request: SaveRequest<UserAcademicRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<UserAcademicRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<UserAcademicRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<UserAcademicRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<UserAcademicRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<UserAcademicRow>>;

    export const Methods = {
        Create: "Masters/UserAcademic/Create",
        Update: "Masters/UserAcademic/Update",
        Delete: "Masters/UserAcademic/Delete",
        Retrieve: "Masters/UserAcademic/Retrieve",
        List: "Masters/UserAcademic/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>UserAcademicService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}