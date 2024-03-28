import { ContentForm, ContentRow, ContentService } from '@/ServerTypes/Content';
import { Decorators, EntityDialog, TabsExtensions } from '@serenity-is/corelib';
import { ContentAudioGrid } from '../ContentAudio/ContentAudioGrid';
import { ContentSubtitleGrid } from '../ContentSubtitle/ContentSubtitleGrid';
import { ContentCommentGrid } from '../ContentComment/ContentCommentGrid';
import { ContentMediaRatingGrid } from '../ContentMediaRating/ContentMediaRatingGrid';

@Decorators.registerClass('GXpert.Content.ContentDialog')
export class ContentDialog extends EntityDialog<ContentRow, any> {
    protected getFormKey() { return ContentForm.formKey; }
    protected getRowDefinition() { return ContentRow; }
    protected getService() { return ContentService.baseUrl; }

    protected form = new ContentForm(this.idPrefix);
    private contentAudioGrid: ContentAudioGrid;
    private contentSubtitlesGrid: ContentSubtitleGrid;
    private contentCommentGrid: ContentCommentGrid;
    private contentMediaRatingsGrid: ContentMediaRatingGrid;
    private loadedState: string;
    constructor() {
        super();

        this.contentAudioGrid = new ContentAudioGrid(this.byId('ContentAudioGrid'));
        this.contentAudioGrid.openDialogsAsPanel = false;

        this.contentSubtitlesGrid = new ContentSubtitleGrid(this.byId('ContentSubtitleGrid'));
        this.contentSubtitlesGrid.openDialogsAsPanel = false;

        this.contentCommentGrid = new ContentCommentGrid(this.byId('ContentCommentGrid'));
        this.contentCommentGrid.openDialogsAsPanel = false;

        this.contentMediaRatingsGrid = new ContentMediaRatingGrid(this.byId('ContentMediaRatingGrid'));
        this.contentMediaRatingsGrid.openDialogsAsPanel = false;
    }

    getSaveState() {
        try {
            return $.toJSON(this.getSaveEntity());
        }
        catch (e) {
            return null;
        }
    }

    loadResponse(data) {
        super.loadResponse(data);
        this.loadedState = this.getSaveState();
    }

    loadEntity(entity: ContentRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'ContentAudio', this.isNewOrDeleted());

        TabsExtensions.setDisabled(this.tabs, 'ContentSubtitle', this.isNewOrDeleted());

        TabsExtensions.setDisabled(this.tabs, 'ContentComment', this.isNewOrDeleted());

        TabsExtensions.setDisabled(this.tabs, 'ContentMediaRating', this.isNewOrDeleted());

       
    }

    protected afterLoadEntity() {
        super.afterLoadEntity();

        this.contentAudioGrid.ContentId = this.entityId;
        this.contentSubtitlesGrid.ContentId = this.entityId;
        this.contentCommentGrid.ContentId = this.entityId;
        this.contentMediaRatingsGrid.ContentId = this.entityId;

        //if (Authorization.hasPermission("Administration:Security")) {
        //    this.form.UserId.getGridField().toggle(false);
        //}
        //else {
        //    this.form.UserId.getGridField().toggle(false);
        //}
    }

    onSaveSuccess(response) {
        super.onSaveSuccess(response);

        TabsExtensions.setDisabled(this.tabs, 'ContentAudio', this.isNewOrDeleted());

        TabsExtensions.setDisabled(this.tabs, 'ContentSubtitle', this.isNewOrDeleted());

        TabsExtensions.setDisabled(this.tabs, 'ContentComment', this.isNewOrDeleted());

        TabsExtensions.setDisabled(this.tabs, 'ContentMediaRating', this.isNewOrDeleted());

        this.loadedState = this.getSaveState();
    }

    getTemplate() {
        return `<div id="~_Tabs" class="s-DialogContent">
    <ul>
        <li><a href="#~_TabInfo"><span>General</span></a></li>
        <li><a href="#~_TabContentAudio"><span>Content Audio</span></a></li>
        <li><a href="#~_TabContentSubtitle"><span>Content Subtitle</span></a></li>
        <li><a href="#~_TabContentComment"><span>ContentComment</span></a></li>
        <li><a href="#~_TabContentMediaRating"><span>Content Media Rating</span></a></li>
       
    </ul>
    <div id="~_TabInfo" class="tab-pane s-TabInfo">
        <div id="~_Toolbar" class="s-DialogToolbar">
        </div>
        <div class="s-Form">
            <form id="~_Form" action="">
                <div class="fieldset ui-widget ui-widget-content ui-corner-all">
                    <div id="~_PropertyGrid"></div>
                    <div class="clear"></div>
                </div>
            </form>
        </div>
    </div>
    <div id="~_TabContentAudio" class="tab-pane s-ContentAudio">
        <div id="~_ContentAudioGrid">
        </div>
    </div>
    <div id="~_TabContentSubtitle" class="tab-pane s-ContentSubtitle">
        <div id="~_ContentSubtitleGrid">
        </div>
    </div>
    <div id="~_TabContentComment" class="tab-pane s-ContentComment">
        <div id="~_ContentCommentGrid">
        </div>
    </div>
    <div id="~_TabContentMediaRating" class="tab-pane s-ContentMediaRating">
        <div id="~_ContentMediaRatingGrid">
        </div>
    </div>
    
</div>`;
    }

}