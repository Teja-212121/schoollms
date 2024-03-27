import { PlayListContentColumns, PlayListContentRow, PlayListContentService } from '@/ServerTypes/Playlist';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PlayListContentDialog } from './PlayListcontentDialog';

@Decorators.registerClass('GXpert.Playlist.PlayListContentGrid')
export class PlayListContentGrid extends EntityGrid<PlayListContentRow, any> {
    protected getColumnsKey() { return PlayListContentColumns.columnsKey; }
    protected getDialogType() { return PlayListContentDialog; }
    protected getRowDefinition() { return PlayListContentRow; }
    protected getService() { return PlayListContentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}