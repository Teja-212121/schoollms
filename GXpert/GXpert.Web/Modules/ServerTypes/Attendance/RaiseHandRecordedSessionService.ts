import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { RaiseHandRecordedSessionRow } from "./RaiseHandRecordedSessionRow";

export namespace RaiseHandRecordedSessionService {
    export const baseUrl = 'Attendance/RaiseHandRecordedSession';

    export declare function Create(request: SaveRequest<RaiseHandRecordedSessionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<RaiseHandRecordedSessionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<RaiseHandRecordedSessionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<RaiseHandRecordedSessionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<RaiseHandRecordedSessionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<RaiseHandRecordedSessionRow>>;

    export const Methods = {
        Create: "Attendance/RaiseHandRecordedSession/Create",
        Update: "Attendance/RaiseHandRecordedSession/Update",
        Delete: "Attendance/RaiseHandRecordedSession/Delete",
        Retrieve: "Attendance/RaiseHandRecordedSession/Retrieve",
        List: "Attendance/RaiseHandRecordedSession/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>RaiseHandRecordedSessionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}