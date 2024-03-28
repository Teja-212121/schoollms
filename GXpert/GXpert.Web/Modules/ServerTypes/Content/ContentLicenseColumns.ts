import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContentLicenseRow } from "./ContentLicenseRow";

export interface ContentLicenseColumns {
    Id: Column<ContentLicenseRow>;
    Name: Column<ContentLicenseRow>;
    Description: Column<ContentLicenseRow>;
}

export class ContentLicenseColumns extends ColumnsBase<ContentLicenseRow> {
    static readonly columnsKey = 'Content.ContentLicense';
    static readonly Fields = fieldsProxy<ContentLicenseColumns>();
}