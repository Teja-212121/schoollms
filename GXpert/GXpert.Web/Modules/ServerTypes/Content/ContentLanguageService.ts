import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ContentLanguageRow } from "./ContentLanguageRow";

export namespace ContentLanguageService {
    export const baseUrl = 'Content/ContentLanguage';

    export declare function Create(request: SaveRequest<ContentLanguageRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ContentLanguageRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContentLanguageRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ContentLanguageRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ContentLanguageRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ContentLanguageRow>>;

    export const Methods = {
        Create: "Content/ContentLanguage/Create",
        Update: "Content/ContentLanguage/Update",
        Delete: "Content/ContentLanguage/Delete",
        Retrieve: "Content/ContentLanguage/Retrieve",
        List: "Content/ContentLanguage/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ContentLanguageService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}