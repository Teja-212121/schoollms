import { ContentSubtitleColumns, ContentSubtitleRow, ContentSubtitleService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentSubtitleDialog } from './ContentSubtitleDialog';

@Decorators.registerClass('GXpert.Content.ContentSubtitleGrid')
export class ContentSubtitleGrid extends EntityGrid<ContentSubtitleRow, any> {
    protected getColumnsKey() { return ContentSubtitleColumns.columnsKey; }
    protected getDialogType() { return ContentSubtitleDialog; }
    protected getRowDefinition() { return ContentSubtitleRow; }
    protected getService() { return ContentSubtitleService.baseUrl; }

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