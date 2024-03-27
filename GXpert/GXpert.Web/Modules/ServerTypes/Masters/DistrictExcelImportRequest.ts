import { ServiceRequest } from "@serenity-is/corelib";

export interface DistrictExcelImportRequest extends ServiceRequest {
    FileName?: string;
}