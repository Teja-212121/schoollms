import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SkillRow } from "./SkillRow";

export namespace SkillService {
    export const baseUrl = 'Skills/Skill';

    export declare function Create(request: SaveRequest<SkillRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SkillRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SkillRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SkillRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SkillRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SkillRow>>;

    export const Methods = {
        Create: "Skills/Skill/Create",
        Update: "Skills/Skill/Update",
        Delete: "Skills/Skill/Delete",
        Retrieve: "Skills/Skill/Retrieve",
        List: "Skills/Skill/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SkillService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}