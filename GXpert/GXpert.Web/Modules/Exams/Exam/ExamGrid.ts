import { ExamColumns, ExamRow, ExamService } from '@/ServerTypes/Exams';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamDialog } from './ExamDialog';

@Decorators.registerClass('GXpert.Exams.ExamGrid')
export class ExamGrid extends EntityGrid<ExamRow, any> {
    protected getColumnsKey() { return ExamColumns.columnsKey; }
    protected getDialogType() { return ExamDialog; }
    protected getRowDefinition() { return ExamRow; }
    protected getService() { return ExamService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}