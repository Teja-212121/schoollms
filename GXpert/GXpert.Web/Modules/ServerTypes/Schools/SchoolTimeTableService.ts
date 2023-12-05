import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SchoolTimeTableRow } from "./SchoolTimeTableRow";

export namespace SchoolTimeTableService {
    export const baseUrl = 'Schools/SchoolTimeTable';

    export declare function Create(request: SaveRequest<SchoolTimeTableRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SchoolTimeTableRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SchoolTimeTableRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SchoolTimeTableRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SchoolTimeTableRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SchoolTimeTableRow>>;

    export const Methods = {
        Create: "Schools/SchoolTimeTable/Create",
        Update: "Schools/SchoolTimeTable/Update",
        Delete: "Schools/SchoolTimeTable/Delete",
        Retrieve: "Schools/SchoolTimeTable/Retrieve",
        List: "Schools/SchoolTimeTable/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SchoolTimeTableService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}