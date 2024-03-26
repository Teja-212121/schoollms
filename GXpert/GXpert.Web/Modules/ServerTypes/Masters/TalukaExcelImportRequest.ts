import { ServiceRequest } from "@serenity-is/corelib";

export interface TalukaExcelImportRequest extends ServiceRequest {
    FileName?: string;
}