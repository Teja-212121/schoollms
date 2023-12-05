import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { LiveSessionRow } from "./LiveSessionRow";

export namespace LiveSessionService {
    export const baseUrl = 'LiveSessions/LiveSession';

    export declare function Create(request: SaveRequest<LiveSessionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<LiveSessionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<LiveSessionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<LiveSessionRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<LiveSessionRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<LiveSessionRow>>;

    export const Methods = {
        Create: "LiveSessions/LiveSession/Create",
        Update: "LiveSessions/LiveSession/Update",
        Delete: "LiveSessions/LiveSession/Delete",
        Retrieve: "LiveSessions/LiveSession/Retrieve",
        List: "LiveSessions/LiveSession/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>LiveSessionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}