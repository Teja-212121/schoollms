import { ExamQuestionColumns, ExamQuestionRow, ExamQuestionService } from '@/ServerTypes/Exams';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamQuestionDialog } from './ExamQuestionDialog';

@Decorators.registerClass('GXpert.Exams.ExamQuestionGrid')
export class ExamQuestionGrid extends EntityGrid<ExamQuestionRow, any> {
    protected getColumnsKey() { return ExamQuestionColumns.columnsKey; }
    protected getDialogType() { return ExamQuestionDialog; }
    protected getRowDefinition() { return ExamQuestionRow; }
    protected getService() { return ExamQuestionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected addButtonClick() {
        this.editItem({ ExamId: this.ExamId });
    }

    protected getInitialTitle() {
        return null;
    }

    protected getGridCanLoad() {
        return super.getGridCanLoad() && !!this.ExamId;
    }

    private _ExamId: string;

    get ExamId() {
        return this._ExamId;
    }

    set ExamId(value: string) {
        if (this._ExamId !== value) {
            this._ExamId = value;
            this.setEquality('ExamId', value);
            this.refresh();
        }
    }
}