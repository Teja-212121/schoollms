import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentMediaRatingRow } from "./ContentMediaRatingRow";

export namespace ContentMediaRatingService {
    export const baseUrl = 'Content/ContentMediaRating';

    export declare function Create(request: SaveRequest<ContentMediaRatingRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentMediaRatingRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentMediaRatingRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentMediaRatingRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentMediaRatingRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentMediaRatingRow>>;

    export const Methods = {
        Create: "Content/ContentMediaRating/Create",
        Update: "Content/ContentMediaRating/Update",
        Delete: "Content/ContentMediaRating/Delete",
        Retrieve: "Content/ContentMediaRating/Retrieve",
        List: "Content/ContentMediaRating/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentMediaRatingService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}