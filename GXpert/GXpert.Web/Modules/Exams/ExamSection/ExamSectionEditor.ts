
import { Authorization, Decorators } from '@serenity-is/corelib';
import { GridEditorBase } from '@serenity-is/extensions';
import { ExamSectionDialog } from './ExamSectionDialog';
import { ExamSectionColumns, ExamSectionRow } from '../../ServerTypes/Exams';

@Decorators.registerEditor('GXpert.Exams.ExamSectionEditor')
export class ExamSectionEditor extends GridEditorBase<ExamSectionRow> {
    protected getColumnsKey() { return ExamSectionColumns.columnsKey; }
    protected getDialogType() { return ExamSectionDialog; }
    protected getLocalTextPrefix() { return ExamSectionRow.localTextPrefix; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getColumns() {
        var columns = super.getColumns();
        //if (!Authorization.hasPermission("Administration:Security")) {
        //    columns = columns.filter(f => f.field != ExamSectionRow.Fields.TenantId);
        //}
        return columns;
    }

    protected getAddButtonCaption() {
        return "Add";
    }
}