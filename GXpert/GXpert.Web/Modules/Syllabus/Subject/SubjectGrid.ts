import { SubjectColumns, SubjectRow, SubjectService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SubjectDialog } from './SubjectDialog';

@Decorators.registerClass('GXpert.Syllabus.SubjectGrid')
export class SubjectGrid extends EntityGrid<SubjectRow, any> {
    protected getColumnsKey() { return SubjectColumns.columnsKey; }
    protected getDialogType() { return SubjectDialog; }
    protected getRowDefinition() { return SubjectRow; }
    protected getService() { return SubjectService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}