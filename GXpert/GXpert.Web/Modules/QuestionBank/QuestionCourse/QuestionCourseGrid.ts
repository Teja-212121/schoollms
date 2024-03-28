import { QuestionCourseColumns, QuestionCourseRow, QuestionCourseService } from '@/ServerTypes/QuestionBank';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { QuestionCourseDialog } from './QuestionCourseDialog';

@Decorators.registerClass('GXpert.QuestionBank.QuestionCourseGrid')
export class QuestionCourseGrid extends EntityGrid<QuestionCourseRow, any> {
    protected getColumnsKey() { return QuestionCourseColumns.columnsKey; }
    protected getDialogType() { return QuestionCourseDialog; }
    protected getRowDefinition() { return QuestionCourseRow; }
    protected getService() { return QuestionCourseService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}