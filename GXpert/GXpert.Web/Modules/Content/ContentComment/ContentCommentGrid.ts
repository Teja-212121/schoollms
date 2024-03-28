import { ContentCommentColumns, ContentCommentRow, ContentCommentService } from '@/ServerTypes/Content';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ContentCommentDialog } from './ContentCommentDialog';

@Decorators.registerClass('GXpert.Content.ContentCommentGrid')
export class ContentCommentGrid extends EntityGrid<ContentCommentRow, any> {
    protected getColumnsKey() { return ContentCommentColumns.columnsKey; }
    protected getDialogType() { return ContentCommentDialog; }
    protected getRowDefinition() { return ContentCommentRow; }
    protected getService() { return ContentCommentService.baseUrl; }

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