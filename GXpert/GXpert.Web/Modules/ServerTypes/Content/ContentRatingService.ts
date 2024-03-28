import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentRatingRow } from "./ContentRatingRow";

export namespace ContentRatingService {
    export const baseUrl = 'Content/ContentRating';

    export declare function Create(request: SaveRequest<ContentRatingRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentRatingRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentRatingRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentRatingRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentRatingRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentRatingRow>>;

    export const Methods = {
        Create: "Content/ContentRating/Create",
        Update: "Content/ContentRating/Update",
        Delete: "Content/ContentRating/Delete",
        Retrieve: "Content/ContentRating/Retrieve",
        List: "Content/ContentRating/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentRatingService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}