import { ServiceRequest } from "@serenity-is/corelib";

export interface StateExcelImportRequest extends ServiceRequest {
    FileName?: string;
}