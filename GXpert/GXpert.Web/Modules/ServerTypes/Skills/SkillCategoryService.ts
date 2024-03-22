import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SkillCategoryRow } from "./SkillCategoryRow";

export namespace SkillCategoryService {
    export const baseUrl = 'Skills/SkillCategory';

    export declare function Create(request: SaveRequest<SkillCategoryRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SkillCategoryRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SkillCategoryRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SkillCategoryRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SkillCategoryRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SkillCategoryRow>>;

    export const Methods = {
        Create: "Skills/SkillCategory/Create",
        Update: "Skills/SkillCategory/Update",
        Delete: "Skills/SkillCategory/Delete",
        Retrieve: "Skills/SkillCategory/Retrieve",
        List: "Skills/SkillCategory/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SkillCategoryService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}