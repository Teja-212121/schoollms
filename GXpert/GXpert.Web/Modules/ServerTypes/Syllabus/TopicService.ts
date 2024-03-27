import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";
import { TopicRow } from "./TopicRow";

export namespace TopicService {
    export const baseUrl = 'Syllabus/Topic';

    export declare function Create(request: SaveRequest<TopicRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<TopicRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TopicRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<TopicRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TopicRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<TopicRow>>;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): PromiseLike<ExcelImportResponse>;

    export const Methods = {
        Create: "Syllabus/Topic/Create",
        Update: "Syllabus/Topic/Update",
        Delete: "Syllabus/Topic/Delete",
        Retrieve: "Syllabus/Topic/Retrieve",
        List: "Syllabus/Topic/List",
        ExcelImport: "Syllabus/Topic/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>TopicService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}