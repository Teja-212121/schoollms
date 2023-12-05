import { ClassColumns, ClassRow, ClassService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ClassDialog } from './ClassDialog';

@Decorators.registerClass('GXpert.Syllabus.ClassGrid')
export class ClassGrid extends EntityGrid<ClassRow, any> {
    protected getColumnsKey() { return ClassColumns.columnsKey; }
    protected getDialogType() { return ClassDialog; }
    protected getRowDefinition() { return ClassRow; }
    protected getService() { return ClassService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}