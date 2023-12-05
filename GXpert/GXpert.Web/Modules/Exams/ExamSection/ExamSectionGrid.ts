import { ExamSectionColumns, ExamSectionRow, ExamSectionService } from '@/ServerTypes/Exams';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamSectionDialog } from './ExamSectionDialog';

@Decorators.registerClass('GXpert.Exams.ExamSectionGrid')
export class ExamSectionGrid extends EntityGrid<ExamSectionRow, any> {
    protected getColumnsKey() { return ExamSectionColumns.columnsKey; }
    protected getDialogType() { return ExamSectionDialog; }
    protected getRowDefinition() { return ExamSectionRow; }
    protected getService() { return ExamSectionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}