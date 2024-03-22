import { CourseColumns, CourseRow, CourseService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CourseDialog } from './CourseDialog';

@Decorators.registerClass('GXpert.Syllabus.CourseGrid')
export class CourseGrid extends EntityGrid<CourseRow, any> {
    protected getColumnsKey() { return CourseColumns.columnsKey; }
    protected getDialogType() { return CourseDialog; }
    protected getRowDefinition() { return CourseRow; }
    protected getService() { return CourseService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}