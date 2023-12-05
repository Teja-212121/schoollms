import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SchoolRow } from "./SchoolRow";

export namespace SchoolService {
    export const baseUrl = 'Schools/School';

    export declare function Create(request: SaveRequest<SchoolRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SchoolRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SchoolRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SchoolRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SchoolRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SchoolRow>>;

    export const Methods = {
        Create: "Schools/School/Create",
        Update: "Schools/School/Update",
        Delete: "Schools/School/Delete",
        Retrieve: "Schools/School/Retrieve",
        List: "Schools/School/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SchoolService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}