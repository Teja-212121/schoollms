import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AnalyticsLogRow } from "./AnalyticsLogRow";

export interface AnalyticsLogColumns {
    Id: Column<AnalyticsLogRow>;
    ContentTitle: Column<AnalyticsLogRow>;
    ActivationDeviceId: Column<AnalyticsLogRow>;
    StudentPrn: Column<AnalyticsLogRow>;
    StartDatetime: Column<AnalyticsLogRow>;
    EndDateTime: Column<AnalyticsLogRow>;
    TimeSpent: Column<AnalyticsLogRow>;
}

export class AnalyticsLogColumns extends ColumnsBase<AnalyticsLogRow> {
    static readonly columnsKey = 'Analytics.AnalyticsLog';
    static readonly Fields = fieldsProxy<AnalyticsLogColumns>();
}