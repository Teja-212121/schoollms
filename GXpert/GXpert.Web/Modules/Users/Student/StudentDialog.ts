import { StudentForm, StudentRow, StudentService } from '@/ServerTypes/Users';
import { Decorators, EntityDialog, TabsExtensions } from '@serenity-is/corelib';
import { PreAcademicScoreGrid } from '../../Masters/PreAcademicScore/PreAcademicScoreGrid';

import { AcademicPerformanceGrid } from '../../Masters/AcademicPerformance/AcademicPerformanceGrid';

import { UserAcademicGrid } from '../../Masters/UserAcademic/UserAcademicGrid';
import { ProjectGrid } from '../../Masters/Project/ProjectGrid';
import { AcademicSubjectPerformanceGrid } from '../../Masters/AcademicSubjectPerformance/AcademicSubjectPerformanceGrid';


@Decorators.registerClass('GXpert.Users.StudentDialog')
export class StudentDialog extends EntityDialog<StudentRow, any> {
    preAcademicScoreGrid: any;
    loadedState: string;
   
    academicPerformanceGrid: AcademicPerformanceGrid;
    
    userAcademicGrid: UserAcademicGrid;
    projectGrid: ProjectGrid;
    academicSubjectPerformanceGrid: AcademicSubjectPerformanceGrid;
  
  
    protected getFormKey() { return StudentForm.formKey; }
    protected getRowDefinition() { return StudentRow; }
    protected getService() { return StudentService.baseUrl; }

    protected form = new StudentForm(this.idPrefix);

    constructor() {
        super();

        this.preAcademicScoreGrid = new PreAcademicScoreGrid(this.byId('PreAcademicScoreGrid'));
        this.preAcademicScoreGrid.openDialogsAsPanel = false;

        this.academicPerformanceGrid = new AcademicPerformanceGrid(this.byId('AcademicPerformanceGrid'));
        this.academicPerformanceGrid.openDialogsAsPanel = false;

        this.projectGrid = new ProjectGrid(this.byId('ProjectGrid'));
        this.projectGrid.openDialogsAsPanel = false;

        this.userAcademicGrid = new UserAcademicGrid(this.byId('UserAcademicGrid'));
        this.userAcademicGrid.openDialogsAsPanel = false;

        this.academicSubjectPerformanceGrid = new AcademicSubjectPerformanceGrid(this.byId('AcademicSubjectPerformanceGrid'));
        this.academicSubjectPerformanceGrid.openDialogsAsPanel = false;
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

    loadEntity(entity: StudentRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'PreAcademicScore', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'AcademicPerformance', this.isNewOrDeleted());
     // TabsExtensions.setDisabled(this.tabs, 'AcademicSubjectPerformance', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'Project', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'UserAcademic', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'AcademicSubjectPerformance', this.isNewOrDeleted());
    }

    protected afterLoadEntity() {
        super.afterLoadEntity();

        this.preAcademicScoreGrid.StudentId = this.entityId;
        this.academicPerformanceGrid.StudentId = this.entityId;
        //this.academicSubjectPerformanceGrid.StudentId = this.entityId;
        this.projectGrid.StudentId = this.entityId;
        this.userAcademicGrid.StudentId = this.entityId;
        this.academicSubjectPerformanceGrid.StudentId = this.entityId;
    }

    onSaveSuccess(response) {
        super.onSaveSuccess(response);

        TabsExtensions.setDisabled(this.tabs, 'PreAcademicScore', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'AcademicPerformance', this.isNewOrDeleted());
     //TabsExtensions.setDisabled(this.tabs, 'AcademicSubjectPerformance', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'Project', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'UserAcademic', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'AcademicSubjectPerformance', this.isNewOrDeleted());
        this.loadedState = this.getSaveState();
    }

    getTemplate() {
        return `<div id="~_Tabs" class="s-DialogContent">
    <ul>
        <li><a href="#~_TabInfo"><span>General</span></a></li>
        <li><a href="#~_TabPreAcademicScore"><span>PreAcademic Score</span></a></li>
        <li><a href="#~_TabAcademicPerformance"><span>Academic Performance</span></a></li>
      <li><a href="#~_TabAcademicSubjectPerformance"><span>Academic Subject Performance</span></a></li>
        <li><a href="#~_TabProject"><span>Project</span></a></li>
        <li><a href="#~_TabUserAcademic"><span>User Academic</span></a></li>
         
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
    <div id="~_TabPreAcademicScore" class="tab-pane s-PreAcademicScore">
        <div id="~_PreAcademicScoreGrid">
        </div>
    </div>
    <div id="~_TabAcademicPerformance" class="tab-pane s-AcademicPerformance">
        <div id="~_AcademicPerformanceGrid">
        </div>
    </div>
    <div id="~_TabAcademicSubjectPerformance" class="tab-pane s-AcademicSubjectPerformance">
        <div id="~_AcademicSubjectPerformanceGrid">
        </div>
    </div>
   <div id="~_TabProject" class="tab-pane s-Project">
        <div id="~_ProjectGrid">
        </div>
    </div>
    <div id="~_TabUserAcademic" class="tab-pane s-UserAcademic">
        <div id="~_UserAcademicGrid">
        </div>
    </div>
     <div id="~_TabAcademicSubjectPerformance" class="tab-pane s-AcademicSubjectPerformance">
        <div id="~_AcademicSubjectPerformanceGrid">
        </div>
    </div>
</div>`;
    }
}