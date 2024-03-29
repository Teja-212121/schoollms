import { ExamForm, ExamRow, ExamService } from '@/ServerTypes/Exams';
import { Decorators, EntityDialog, TabsExtensions } from '@serenity-is/corelib';
import { ExamQuestionGrid } from '../ExamQuestion/ExamQuestionGrid';

@Decorators.registerClass('GXpert.Exams.ExamDialog')
export class ExamDialog extends EntityDialog<ExamRow, any> {
    protected getFormKey() { return ExamForm.formKey; }
    protected getRowDefinition() { return ExamRow; }
    protected getService() { return ExamService.baseUrl; }

    protected form = new ExamForm(this.idPrefix);
    private ExamQuestionGrid: ExamQuestionGrid;
   
    private loadedState: string;
    constructor() {
        super();

        this.ExamQuestionGrid = new ExamQuestionGrid(this.byId('ContentAudioGrid'));
        this.ExamQuestionGrid.openDialogsAsPanel = false;

        
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

    loadEntity(entity: ExamRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'ExamQuestion', this.isNewOrDeleted());

      


    }

    protected afterLoadEntity() {
        super.afterLoadEntity();

        this.ExamQuestionGrid.ExamId = this.entityId;
       
        //if (Authorization.hasPermission("Administration:Security")) {
        //    this.form.UserId.getGridField().toggle(false);
        //}
        //else {
        //    this.form.UserId.getGridField().toggle(false);
        //}
    }

    onSaveSuccess(response) {
        super.onSaveSuccess(response);

        TabsExtensions.setDisabled(this.tabs, 'ExamQuestion', this.isNewOrDeleted());

     

        this.loadedState = this.getSaveState();
    }

    getTemplate() {
        return `<div id="~_Tabs" class="s-DialogContent">
    <ul>
        <li><a href="#~_TabInfo"><span>General</span></a></li>
        <li><a href="#~_TabContentAudio"><span>Exam Question</span></a></li>
       
       
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
    
    
</div>`;
    }
}