import { InstituteDivisionForm, InstituteDivisionRow, InstituteDivisionService } from '@/ServerTypes/Institute';
import { Decorators, EntityDialog, TabsExtensions } from '@serenity-is/corelib';
import { InstituteStudentGrid } from '../InstituteStudent/InstituteStudentGrid';

@Decorators.registerClass('GXpert.Institute.InstituteDivisionDialog')
export class InstituteDivisionDialog extends EntityDialog<InstituteDivisionRow, any> {
    instituteStudentGrid: InstituteStudentGrid;
    loadedState: string;
    protected getFormKey() { return InstituteDivisionForm.formKey; }
    protected getRowDefinition() { return InstituteDivisionRow; }
    protected getService() { return InstituteDivisionService.baseUrl; }

    protected form = new InstituteDivisionForm(this.idPrefix);

    constructor() {
        super();

        this.instituteStudentGrid = new InstituteStudentGrid(this.byId('InstituteStudentGrid'));
        this.instituteStudentGrid.openDialogsAsPanel = false;

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
    loadEntity(entity: InstituteDivisionRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'InstituteStudent', this.isNewOrDeleted());
       
    }
    protected afterLoadEntity() {
        super.afterLoadEntity();

        this.instituteStudentGrid.StudentId = this.entityId;
      
    }
    onSaveSuccess(response) {
        super.onSaveSuccess(response);

        TabsExtensions.setDisabled(this.tabs, 'InstituteStudent', this.isNewOrDeleted());
       
        this.loadedState = this.getSaveState();
    }
    getTemplate() {
        return `<div id="~_Tabs" class="s-DialogContent">
    <ul>
        <li><a href="#~_TabInfo"><span>General</span></a></li>
        <li><a href="#~_TabInstituteStudent"><span>Institute Student</span></a></li>
        
         
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
    <div id="~_TabInstituteStudent" class="tab-pane s-InstituteStudent">
        <div id="~_InstituteStudentGrid">
        </div>
    </div>
   
</div>`;
    }
}