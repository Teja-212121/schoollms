import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExcelImportResponse } from "@serenity-is/extensions";
import { StateExcelImportRequest } from "./StateExcelImportRequest";
import { StudentClassAttendanceRow } from "./StudentClassAttendanceRow";

export namespace StudentClassAttendanceService {
    export const baseUrl = 'Attendance/StudentClassAttendance';

    export declare function Create(request: SaveRequest<StudentClassAttendanceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<StudentClassAttendanceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<StudentClassAttendanceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<StudentClassAttendanceRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<StudentClassAttendanceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<StudentClassAttendanceRow>>;
    export declare function ExcelImport(request: StateExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): PromiseLike<ExcelImportResponse>;

    export const Methods = {
        Create: "Attendance/StudentClassAttendance/Create",
        Update: "Attendance/StudentClassAttendance/Update",
        Delete: "Attendance/StudentClassAttendance/Delete",
        Retrieve: "Attendance/StudentClassAttendance/Retrieve",
        List: "Attendance/StudentClassAttendance/List",
        ExcelImport: "Attendance/StudentClassAttendance/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>StudentClassAttendanceService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}