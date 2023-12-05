import { ExamAttemptColumns, ExamAttemptRow, ExamAttemptService } from '@/ServerTypes/Analytics';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamAttemptDialog } from './ExamAttemptDialog';

@Decorators.registerClass('GXpert.Analytics.ExamAttemptGrid')
export class ExamAttemptGrid extends EntityGrid<ExamAttemptRow, any> {
    protected getColumnsKey() { return ExamAttemptColumns.columnsKey; }
    protected getDialogType() { return ExamAttemptDialog; }
    protected getRowDefinition() { return ExamAttemptRow; }
    protected getService() { return ExamAttemptService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}