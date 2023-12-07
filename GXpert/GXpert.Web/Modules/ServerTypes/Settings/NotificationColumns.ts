import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { NotificationRow } from "./NotificationRow";

export interface NotificationColumns {
    Id: Column<NotificationRow>;
    NotificationGuid: Column<NotificationRow>;
    Message: Column<NotificationRow>;
    Title: Column<NotificationRow>;
    CreatedOnUtc: Column<NotificationRow>;
    SentTries: Column<NotificationRow>;
    SentOnUtc: Column<NotificationRow>;
    HasError: Column<NotificationRow>;
    Result: Column<NotificationRow>;
}

export class NotificationColumns extends ColumnsBase<NotificationRow> {
    static readonly columnsKey = 'Settings.Notification';
    static readonly Fields = fieldsProxy<NotificationColumns>();
}