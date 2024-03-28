import { ContentMediaRatingColumns, ContentMediaRatingRow, ContentMediaRatingService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentMediaRatingDialog } from './ContentMediaRatingDialog';

@Decorators.registerClass('GXpert.Content.ContentMediaRatingGrid')
export class ContentMediaRatingGrid extends EntityGrid<ContentMediaRatingRow, any> {
    protected getColumnsKey() { return ContentMediaRatingColumns.columnsKey; }
    protected getDialogType() { return ContentMediaRatingDialog; }
    protected getRowDefinition() { return ContentMediaRatingRow; }
    protected getService() { return ContentMediaRatingService.baseUrl; }

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