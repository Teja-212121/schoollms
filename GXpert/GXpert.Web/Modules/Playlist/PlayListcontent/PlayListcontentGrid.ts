import { PlayListcontentColumns, PlayListcontentRow, PlayListcontentService } from '@/ServerTypes/Playlist';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PlayListcontentDialog } from './PlayListcontentDialog';

@Decorators.registerClass('GXpert.Playlist.PlayListcontentGrid')
export class PlayListcontentGrid extends EntityGrid<PlayListcontentRow, any> {
    protected getColumnsKey() { return PlayListcontentColumns.columnsKey; }
    protected getDialogType() { return PlayListcontentDialog; }
    protected getRowDefinition() { return PlayListcontentRow; }
    protected getService() { return PlayListcontentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}