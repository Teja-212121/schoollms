import { AssignedExamTeachersColumns, AssignedExamTeachersRow, AssignedExamTeachersService } from '@/ServerTypes/Analytics';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AssignedExamTeachersDialog } from './AssignedExamTeachersDialog';

@Decorators.registerClass('GXpert.Analytics.AssignedExamTeachersGrid')
export class AssignedExamTeachersGrid extends EntityGrid<AssignedExamTeachersRow, any> {
    protected getColumnsKey() { return AssignedExamTeachersColumns.columnsKey; }
    protected getDialogType() { return AssignedExamTeachersDialog; }
    protected getRowDefinition() { return AssignedExamTeachersRow; }
    protected getService() { return AssignedExamTeachersService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}