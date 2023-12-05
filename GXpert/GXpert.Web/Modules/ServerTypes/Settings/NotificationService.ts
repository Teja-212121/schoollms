import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { NotificationRow } from "./NotificationRow";

export namespace NotificationService {
    export const baseUrl = 'Settings/Notification';

    export declare function Create(request: SaveRequest<NotificationRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<NotificationRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<NotificationRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<NotificationRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<NotificationRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<NotificationRow>>;

    export const Methods = {
        Create: "Settings/Notification/Create",
        Update: "Settings/Notification/Update",
        Delete: "Settings/Notification/Delete",
        Retrieve: "Settings/Notification/Retrieve",
        List: "Settings/Notification/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>NotificationService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}