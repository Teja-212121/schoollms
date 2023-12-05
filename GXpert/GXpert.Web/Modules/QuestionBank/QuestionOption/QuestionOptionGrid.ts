import { QuestionOptionColumns, QuestionOptionRow, QuestionOptionService } from '@/ServerTypes/QuestionBank';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { QuestionOptionDialog } from './QuestionOptionDialog';

@Decorators.registerClass('GXpert.QuestionBank.QuestionOptionGrid')
export class QuestionOptionGrid extends EntityGrid<QuestionOptionRow, any> {
    protected getColumnsKey() { return QuestionOptionColumns.columnsKey; }
    protected getDialogType() { return QuestionOptionDialog; }
    protected getRowDefinition() { return QuestionOptionRow; }
    protected getService() { return QuestionOptionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}