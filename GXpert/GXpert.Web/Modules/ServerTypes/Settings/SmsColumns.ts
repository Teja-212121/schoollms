import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SmsRow } from "./SmsRow";

export interface SmsColumns {
    Id: Column<SmsRow>;
    ApiKey: Column<SmsRow>;
    Sender: Column<SmsRow>;
    EntityId: Column<SmsRow>;
    TemplateId: Column<SmsRow>;
    InsertDate: Column<SmsRow>;
    InsertUserId: Column<SmsRow>;
    UpdateDate: Column<SmsRow>;
    UpdateUserId: Column<SmsRow>;
    IsActive: Column<SmsRow>;
}

export class SmsColumns extends ColumnsBase<SmsRow> {
    static readonly columnsKey = 'Settings.Sms';
    static readonly Fields = fieldsProxy<SmsColumns>();
}