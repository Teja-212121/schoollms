import { ServiceRequest } from "@serenity-is/corelib";

export interface PreAcademicScoreExcelImportRequest extends ServiceRequest {
    FileName?: string;
}