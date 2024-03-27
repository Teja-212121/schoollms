import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { InstituteDivisionRow } from "./InstituteDivisionRow";

export namespace InstituteDivisionService {
    export const baseUrl = 'Institute/InstituteDivision';

    export declare function Create(request: SaveRequest<InstituteDivisionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<InstituteDivisionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<InstituteDivisionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<InstituteDivisionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<InstituteDivisionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<InstituteDivisionRow>>;

    export const Methods = {
        Create: "Institute/InstituteDivision/Create",
        Update: "Institute/InstituteDivision/Update",
        Delete: "Institute/InstituteDivision/Delete",
        Retrieve: "Institute/InstituteDivision/Retrieve",
        List: "Institute/InstituteDivision/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>InstituteDivisionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}