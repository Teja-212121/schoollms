import { ServiceRequest } from "@serenity-is/corelib";

export interface AcademicSubjectExcelImportRequest extends ServiceRequest {
    FileName?: string;
}