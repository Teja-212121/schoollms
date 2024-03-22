import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AcademicSubjectPerformanceRow } from "./AcademicSubjectPerformanceRow";

export namespace AcademicSubjectPerformanceService {
    export const baseUrl = 'Masters/AcademicSubjectPerformance';

    export declare function Create(request: SaveRequest<AcademicSubjectPerformanceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AcademicSubjectPerformanceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AcademicSubjectPerformanceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AcademicSubjectPerformanceRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AcademicSubjectPerformanceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AcademicSubjectPerformanceRow>>;

    export const Methods = {
        Create: "Masters/AcademicSubjectPerformance/Create",
        Update: "Masters/AcademicSubjectPerformance/Update",
        Delete: "Masters/AcademicSubjectPerformance/Delete",
        Retrieve: "Masters/AcademicSubjectPerformance/Retrieve",
        List: "Masters/AcademicSubjectPerformance/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AcademicSubjectPerformanceService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}