import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { LiveSessionLogRow } from "./LiveSessionLogRow";

export namespace LiveSessionLogService {
    export const baseUrl = 'LiveSessions/LiveSessionLog';

    export declare function Create(request: SaveRequest<LiveSessionLogRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<LiveSessionLogRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<LiveSessionLogRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<LiveSessionLogRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<LiveSessionLogRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<LiveSessionLogRow>>;

    export const Methods = {
        Create: "LiveSessions/LiveSessionLog/Create",
        Update: "LiveSessions/LiveSessionLog/Update",
        Delete: "LiveSessions/LiveSessionLog/Delete",
        Retrieve: "LiveSessions/LiveSessionLog/Retrieve",
        List: "LiveSessions/LiveSessionLog/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>LiveSessionLogService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}