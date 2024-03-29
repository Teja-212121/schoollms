import { ContentAssignToPlayListcontentForm, PlayListContentRow, PlayListContentService } from '@/ServerTypes/Playlist';
import { Decorators, EntityDialog, ToolButton,  isEmptyOrNull,  notifySuccess } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Playlist.ContentAssignToPlayListcontentDialog')
export class ContentAssignToPlayListcontentDialog extends EntityDialog<PlayListContentRow, any> {
    protected getFormKey() { return ContentAssignToPlayListcontentForm.formKey; }
    protected getRowDefinition() { return PlayListContentRow; }
    protected getService() { return PlayListContentService.baseUrl; }

    protected form = new ContentAssignToPlayListcontentForm(this.idPrefix);
    private IsEditMode: boolean;
    private rowids: string;
    constructor(gridToRefresh, FormMode, selectedids) {
        super();
        this.form.EContentType.change(e => {
            var vContentType = this.form.EContentType.value;

            if (isEmptyOrNull(vContentType)) {
                this.form.PlayListId.getGridField().toggle(false);
                this.form.ContentId.getGridField().toggle(false);
                this.form.ExamId.getGridField().toggle(false);
                this.form.LiveSessionId.getGridField().toggle(false);
                this.form.AssignmentId.getGridField().toggle(false);
            }
            else {

                if (vContentType == '0' || vContentType == '1' || vContentType == '2' || vContentType == '3' || vContentType == '4') {

                    if (vContentType == '0') {
                        this.form.PlayListId.getGridField().toggle(true);
                        this.form.ContentId.getGridField().toggle(false);
                        this.form.ExamId.getGridField().toggle(false);
                        this.form.LiveSessionId.getGridField().toggle(false);
                        this.form.AssignmentId.getGridField().toggle(false);
                    }
                    else if (vContentType == '1') {
                        this.form.PlayListId.getGridField().toggle(false);
                        this.form.ContentId.getGridField().toggle(true);
                        this.form.ExamId.getGridField().toggle(false);
                        this.form.LiveSessionId.getGridField().toggle(false);
                        this.form.AssignmentId.getGridField().toggle(false);
                    }
                    else if (vContentType == '2') {
                        this.form.PlayListId.getGridField().toggle(false);
                        this.form.ContentId.getGridField().toggle(false);
                        this.form.ExamId.getGridField().toggle(true);
                        this.form.LiveSessionId.getGridField().toggle(false);
                        this.form.AssignmentId.getGridField().toggle(false);
                    }
                    else if (vContentType == '3') {
                        this.form.PlayListId.getGridField().toggle(false);
                        this.form.ContentId.getGridField().toggle(false);
                        this.form.ExamId.getGridField().toggle(false);
                        this.form.LiveSessionId.getGridField().toggle(true);
                        this.form.AssignmentId.getGridField().toggle(false);
                    }
                    else {
                        this.form.PlayListId.getGridField().toggle(false);
                        this.form.ContentId.getGridField().toggle(false);
                        this.form.ExamId.getGridField().toggle(false);
                        this.form.LiveSessionId.getGridField().toggle(false);
                        this.form.AssignmentId.getGridField().toggle(true);
                    }
                }
            }
        });
        this.IsEditMode = FormMode;
        this.rowids = selectedids;
        this.dialogTitle = "Assign Playlist";
    }
    protected getToolbarButtons(): ToolButton[] {
        let buttons = super.getToolbarButtons();
        buttons.splice(0, 6);
        buttons.push({
            title: "Assign",
            cssClass: 'edit-permissions-button ',
            icon: 'fa-plus',
            onClick: () => {

                if (!this.validateBeforeSave())
                    return;
                this.entity.RowIds = this.rowids.toString();
                this.entity.PlayListId = Number(this.form.PlayListId.value);
                this.entity.ExamId = Number(this.form.ExamId.value);
                this.entity.LiveSessionId = Number(this.form.LiveSessionId.value);
                this.entity.AssignmentId = Number(this.form.AssignmentId.value);
                this.entity.ModuleId = Number(this.form.ModuleId.value);
                this.entity.EContentType = Number(this.form.EContentType.value);
                this.entity.EPublishStatus = Number(this.form.EPublishStatus.value);
                this.entity.SortOrder = Number(this.form.SortOrder.value);

                PlayListContentService.AssignPlaylist({
                    EntityId: 1,
                    Entity: this.entity

                }, response => {


                    /* this.Studentgrid.refresh();*/
                });
                notifySuccess("Assign Succesfully");
                this.dialogClose();
            }
        });
        buttons.push({
            title: "Cancel",
            icon: 'fa-minus',
            onClick: () => { this.dialogClose() }
        });

        return buttons;

    }
}