import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { MediumRow } from "./MediumRow";

export namespace MediumService {
    export const baseUrl = 'Syllabus/Medium';

    export declare function Create(request: SaveRequest<MediumRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<MediumRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MediumRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<MediumRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<MediumRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<MediumRow>>;

    export const Methods = {
        Create: "Syllabus/Medium/Create",
        Update: "Syllabus/Medium/Update",
        Delete: "Syllabus/Medium/Delete",
        Retrieve: "Syllabus/Medium/Retrieve",
        List: "Syllabus/Medium/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>MediumService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}