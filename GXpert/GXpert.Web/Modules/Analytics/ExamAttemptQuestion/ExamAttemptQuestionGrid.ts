import { ExamAttemptQuestionColumns, ExamAttemptQuestionRow, ExamAttemptQuestionService } from '@/ServerTypes/Analytics';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamAttemptQuestionDialog } from './ExamAttemptQuestionDialog';

@Decorators.registerClass('GXpert.Analytics.ExamAttemptQuestionGrid')
export class ExamAttemptQuestionGrid extends EntityGrid<ExamAttemptQuestionRow, any> {
    protected getColumnsKey() { return ExamAttemptQuestionColumns.columnsKey; }
    protected getDialogType() { return ExamAttemptQuestionDialog; }
    protected getRowDefinition() { return ExamAttemptQuestionRow; }
    protected getService() { return ExamAttemptQuestionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}