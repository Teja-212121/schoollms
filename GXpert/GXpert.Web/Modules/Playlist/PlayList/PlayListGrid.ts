import { PlayListColumns, PlayListRow, PlayListService } from '@/ServerTypes/Playlist';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PlayListDialog } from './PlayListDialog';

@Decorators.registerClass('GXpert.Playlist.PlayListGrid')
export class PlayListGrid extends EntityGrid<PlayListRow, any> {
    protected getColumnsKey() { return PlayListColumns.columnsKey; }
    protected getDialogType() { return PlayListDialog; }
    protected getRowDefinition() { return PlayListRow; }
    protected getService() { return PlayListService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}