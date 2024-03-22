import { UserAcademicColumns, UserAcademicRow, UserAcademicService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { UserAcademicDialog } from './UserAcademicDialog';

@Decorators.registerClass('GXpert.Masters.UserAcademicGrid')
export class UserAcademicGrid extends EntityGrid<UserAcademicRow, any> {
    protected getColumnsKey() { return UserAcademicColumns.columnsKey; }
    protected getDialogType() { return UserAcademicDialog; }
    protected getRowDefinition() { return UserAcademicRow; }
    protected getService() { return UserAcademicService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}