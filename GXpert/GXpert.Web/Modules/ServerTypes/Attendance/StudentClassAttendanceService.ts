import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { StudentClassAttendanceRow } from "./StudentClassAttendanceRow";

export namespace StudentClassAttendanceService {
    export const baseUrl = 'Attendance/StudentClassAttendance';

    export declare function Create(request: SaveRequest<StudentClassAttendanceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<StudentClassAttendanceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<StudentClassAttendanceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<StudentClassAttendanceRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<StudentClassAttendanceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<StudentClassAttendanceRow>>;

    export const Methods = {
        Create: "Attendance/StudentClassAttendance/Create",
        Update: "Attendance/StudentClassAttendance/Update",
        Delete: "Attendance/StudentClassAttendance/Delete",
        Retrieve: "Attendance/StudentClassAttendance/Retrieve",
        List: "Attendance/StudentClassAttendance/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>StudentClassAttendanceService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}