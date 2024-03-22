import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ProjectSkillRow } from "./ProjectSkillRow";

export namespace ProjectSkillService {
    export const baseUrl = 'Masters/ProjectSkill';

    export declare function Create(request: SaveRequest<ProjectSkillRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ProjectSkillRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProjectSkillRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ProjectSkillRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProjectSkillRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ProjectSkillRow>>;

    export const Methods = {
        Create: "Masters/ProjectSkill/Create",
        Update: "Masters/ProjectSkill/Update",
        Delete: "Masters/ProjectSkill/Delete",
        Retrieve: "Masters/ProjectSkill/Retrieve",
        List: "Masters/ProjectSkill/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ProjectSkillService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}