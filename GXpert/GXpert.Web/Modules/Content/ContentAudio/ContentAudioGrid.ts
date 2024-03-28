import { ContentAudioColumns, ContentAudioRow, ContentAudioService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentAudioDialog } from './ContentAudioDialog';

@Decorators.registerClass('GXpert.Content.ContentAudioGrid')
export class ContentAudioGrid extends EntityGrid<ContentAudioRow, any> {
    protected getColumnsKey() { return ContentAudioColumns.columnsKey; }
    protected getDialogType() { return ContentAudioDialog; }
    protected getRowDefinition() { return ContentAudioRow; }
    protected getService() { return ContentAudioService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected addButtonClick() {
        this.editItem({ ContentId: this.ContentId });
    }

    protected getInitialTitle() {
        return null;
    }

    protected getGridCanLoad() {
        return super.getGridCanLoad() && !!this.ContentId;
    }

    private _ContentId: string;

    get ContentId() {
        return this._ContentId;
    }

    set ContentId(value: string) {
        if (this._ContentId !== value) {
            this._ContentId = value;
            this.setEquality('ContentId', value);
            this.refresh();
        }
    }
}