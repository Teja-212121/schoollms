import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PreAcademicRow } from "./PreAcademicRow";

export namespace PreAcademicService {
    export const baseUrl = 'Masters/PreAcademic';

    export declare function Create(request: SaveRequest<PreAcademicRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PreAcademicRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PreAcademicRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PreAcademicRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PreAcademicRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PreAcademicRow>>;

    export const Methods = {
        Create: "Masters/PreAcademic/Create",
        Update: "Masters/PreAcademic/Update",
        Delete: "Masters/PreAcademic/Delete",
        Retrieve: "Masters/PreAcademic/Retrieve",
        List: "Masters/PreAcademic/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PreAcademicService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}