import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PollResponseRow } from "./PollResponseRow";

export namespace PollResponseService {
    export const baseUrl = 'Attendance/PollResponse';

    export declare function Create(request: SaveRequest<PollResponseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PollResponseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PollResponseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PollResponseRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PollResponseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PollResponseRow>>;

    export const Methods = {
        Create: "Attendance/PollResponse/Create",
        Update: "Attendance/PollResponse/Update",
        Delete: "Attendance/PollResponse/Delete",
        Retrieve: "Attendance/PollResponse/Retrieve",
        List: "Attendance/PollResponse/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PollResponseService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}