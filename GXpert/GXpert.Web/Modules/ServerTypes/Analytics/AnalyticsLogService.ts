import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AnalyticsLogRow } from "./AnalyticsLogRow";

export namespace AnalyticsLogService {
    export const baseUrl = 'Analytics/AnalyticsLog';

    export declare function Create(request: SaveRequest<AnalyticsLogRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AnalyticsLogRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AnalyticsLogRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AnalyticsLogRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AnalyticsLogRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AnalyticsLogRow>>;

    export const Methods = {
        Create: "Analytics/AnalyticsLog/Create",
        Update: "Analytics/AnalyticsLog/Update",
        Delete: "Analytics/AnalyticsLog/Delete",
        Retrieve: "Analytics/AnalyticsLog/Retrieve",
        List: "Analytics/AnalyticsLog/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AnalyticsLogService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}