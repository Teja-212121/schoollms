import { PlayListForm, PlayListRow, PlayListService } from '@/ServerTypes/Playlist';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Playlist.PlayListDialog')
export class PlayListDialog extends EntityDialog<PlayListRow, any> {
    protected getFormKey() { return PlayListForm.formKey; }
    protected getRowDefinition() { return PlayListRow; }
    protected getService() { return PlayListService.baseUrl; }

    protected form = new PlayListForm(this.idPrefix);
}