import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AcademicYearRow } from "./AcademicYearRow";

export namespace AcademicYearService {
    export const baseUrl = 'Masters/AcademicYear';

    export declare function Create(request: SaveRequest<AcademicYearRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AcademicYearRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AcademicYearRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AcademicYearRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AcademicYearRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AcademicYearRow>>;

    export const Methods = {
        Create: "Masters/AcademicYear/Create",
        Update: "Masters/AcademicYear/Update",
        Delete: "Masters/AcademicYear/Delete",
        Retrieve: "Masters/AcademicYear/Retrieve",
        List: "Masters/AcademicYear/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AcademicYearService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}