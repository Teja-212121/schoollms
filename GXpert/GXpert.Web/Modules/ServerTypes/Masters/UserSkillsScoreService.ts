import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { UserSkillsScoreRow } from "./UserSkillsScoreRow";

export namespace UserSkillsScoreService {
    export const baseUrl = 'Masters/UserSkillsScore';

    export declare function Create(request: SaveRequest<UserSkillsScoreRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<UserSkillsScoreRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<UserSkillsScoreRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<UserSkillsScoreRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<UserSkillsScoreRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<UserSkillsScoreRow>>;

    export const Methods = {
        Create: "Masters/UserSkillsScore/Create",
        Update: "Masters/UserSkillsScore/Update",
        Delete: "Masters/UserSkillsScore/Delete",
        Retrieve: "Masters/UserSkillsScore/Retrieve",
        List: "Masters/UserSkillsScore/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>UserSkillsScoreService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}