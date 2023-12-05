import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PollRow } from "./PollRow";

export namespace PollService {
    export const baseUrl = 'LiveSessions/Poll';

    export declare function Create(request: SaveRequest<PollRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PollRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PollRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PollRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PollRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PollRow>>;

    export const Methods = {
        Create: "LiveSessions/Poll/Create",
        Update: "LiveSessions/Poll/Update",
        Delete: "LiveSessions/Poll/Delete",
        Retrieve: "LiveSessions/Poll/Retrieve",
        List: "LiveSessions/Poll/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PollService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}