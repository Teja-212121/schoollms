import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ClassRow } from "./ClassRow";

export namespace ClassService {
    export const baseUrl = 'Syllabus/Class';

    export declare function Create(request: SaveRequest<ClassRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ClassRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ClassRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ClassRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ClassRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ClassRow>>;

    export const Methods = {
        Create: "Syllabus/Class/Create",
        Update: "Syllabus/Class/Update",
        Delete: "Syllabus/Class/Delete",
        Retrieve: "Syllabus/Class/Retrieve",
        List: "Syllabus/Class/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ClassService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}