import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SmsRow } from "./SmsRow";

export namespace SmsService {
    export const baseUrl = 'Settings/Sms';

    export declare function Create(request: SaveRequest<SmsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SmsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SmsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SmsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SmsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SmsRow>>;

    export const Methods = {
        Create: "Settings/Sms/Create",
        Update: "Settings/Sms/Update",
        Delete: "Settings/Sms/Delete",
        Retrieve: "Settings/Sms/Retrieve",
        List: "Settings/Sms/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SmsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}