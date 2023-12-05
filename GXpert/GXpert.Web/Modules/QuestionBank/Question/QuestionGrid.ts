import { QuestionColumns, QuestionRow, QuestionService } from '@/ServerTypes/QuestionBank';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { QuestionDialog } from './QuestionDialog';

@Decorators.registerClass('GXpert.QuestionBank.QuestionGrid')
export class QuestionGrid extends EntityGrid<QuestionRow, any> {
    protected getColumnsKey() { return QuestionColumns.columnsKey; }
    protected getDialogType() { return QuestionDialog; }
    protected getRowDefinition() { return QuestionRow; }
    protected getService() { return QuestionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}