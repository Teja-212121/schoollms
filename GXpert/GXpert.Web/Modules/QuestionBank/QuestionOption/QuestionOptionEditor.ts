import { Authorization, Decorators } from '@serenity-is/corelib';
import { GridEditorBase } from '@serenity-is/extensions';

import { QuestionOptionDialog } from './QuestionOptionDialog';
import { QuestionOptionColumns, QuestionOptionRow } from '../../ServerTypes/QuestionBank';

@Decorators.registerEditor('GXpert.QuestionBank.QuestionOptionEditor')
export class QuestionOptionEditor extends GridEditorBase<QuestionOptionRow> {
    protected getColumnsKey() { return QuestionOptionColumns.columnsKey; }
    protected getDialogType() { return QuestionOptionDialog; }
    protected getLocalTextPrefix() { return QuestionOptionRow.localTextPrefix; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getColumns() {
        var columns = super.getColumns();
        //if (!Authorization.hasPermission("Administration:Security")) {
        //    columns = columns.filter(f => f.field != QuestionOptionRow.Fields.TenantId);
        //}
        return columns;
    }

    protected getAddButtonCaption() {
        return "Add";
    }
}