import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SchoolClassRow } from "./SchoolClassRow";

export namespace SchoolClassService {
    export const baseUrl = 'Schools/SchoolClass';

    export declare function Create(request: SaveRequest<SchoolClassRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SchoolClassRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SchoolClassRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SchoolClassRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SchoolClassRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SchoolClassRow>>;

    export const Methods = {
        Create: "Schools/SchoolClass/Create",
        Update: "Schools/SchoolClass/Update",
        Delete: "Schools/SchoolClass/Delete",
        Retrieve: "Schools/SchoolClass/Retrieve",
        List: "Schools/SchoolClass/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SchoolClassService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}