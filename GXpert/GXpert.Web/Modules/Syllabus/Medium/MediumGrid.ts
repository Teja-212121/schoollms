import { MediumColumns, MediumRow, MediumService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { MediumDialog } from './MediumDialog';

@Decorators.registerClass('GXpert.Syllabus.MediumGrid')
export class MediumGrid extends EntityGrid<MediumRow, any> {
    protected getColumnsKey() { return MediumColumns.columnsKey; }
    protected getDialogType() { return MediumDialog; }
    protected getRowDefinition() { return MediumRow; }
    protected getService() { return MediumService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}