import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SmtpRow } from "./SmtpRow";

export namespace SmtpService {
    export const baseUrl = 'Settings/Smtp';

    export declare function Create(request: SaveRequest<SmtpRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SmtpRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SmtpRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SmtpRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SmtpRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SmtpRow>>;

    export const Methods = {
        Create: "Settings/Smtp/Create",
        Update: "Settings/Smtp/Update",
        Delete: "Settings/Smtp/Delete",
        Retrieve: "Settings/Smtp/Retrieve",
        List: "Settings/Smtp/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SmtpService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}