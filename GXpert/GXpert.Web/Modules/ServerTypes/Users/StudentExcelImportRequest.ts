import { ServiceRequest } from "@serenity-is/corelib";

export interface StudentExcelImportRequest extends ServiceRequest {
    FileName?: string;
}