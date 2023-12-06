import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SmtpRow } from "./SmtpRow";

export interface SmtpColumns {
    Id: Column<SmtpRow>;
    Server: Column<SmtpRow>;
    Port: Column<SmtpRow>;
    Username: Column<SmtpRow>;
    Password: Column<SmtpRow>;
    IsSsl: Column<SmtpRow>;
}

export class SmtpColumns extends ColumnsBase<SmtpRow> {
    static readonly columnsKey = 'Settings.Smtp';
    static readonly Fields = fieldsProxy<SmtpColumns>();
}