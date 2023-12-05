import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { RaiseHandLiveSessionRow } from "./RaiseHandLiveSessionRow";

export namespace RaiseHandLiveSessionService {
    export const baseUrl = 'Attendance/RaiseHandLiveSession';

    export declare function Create(request: SaveRequest<RaiseHandLiveSessionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<RaiseHandLiveSessionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<RaiseHandLiveSessionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<RaiseHandLiveSessionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<RaiseHandLiveSessionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<RaiseHandLiveSessionRow>>;

    export const Methods = {
        Create: "Attendance/RaiseHandLiveSession/Create",
        Update: "Attendance/RaiseHandLiveSession/Update",
        Delete: "Attendance/RaiseHandLiveSession/Delete",
        Retrieve: "Attendance/RaiseHandLiveSession/Retrieve",
        List: "Attendance/RaiseHandLiveSession/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>RaiseHandLiveSessionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}