import { ServiceRequest } from "@serenity-is/corelib";

export interface QuestionExcelImportRequest extends ServiceRequest {
    FileName?: string;
}