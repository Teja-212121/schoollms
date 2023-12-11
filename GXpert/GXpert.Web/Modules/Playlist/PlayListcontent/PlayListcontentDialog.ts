import { PlayListContentForm, PlayListContentRow, PlayListContentService } from '@/ServerTypes/Playlist';
import { Decorators, EntityDialog, isEmptyOrNull } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Playlist.PlayListContentDialog')
export class PlayListContentDialog extends EntityDialog<PlayListContentRow, any> {
    protected getFormKey() { return PlayListContentForm.formKey; }
    protected getRowDefinition() { return PlayListContentRow; }
    protected getService() { return PlayListContentService.baseUrl; }

    protected form = new PlayListContentForm(this.idPrefix);

    constructor() {
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

                if (vContentType == '0' || vContentType == '1' ||vContentType == '2' ||vContentType == '3' ||vContentType == '4') {

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
    }
}