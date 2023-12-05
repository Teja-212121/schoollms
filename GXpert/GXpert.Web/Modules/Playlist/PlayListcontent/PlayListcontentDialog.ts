import { PlayListcontentForm, PlayListcontentRow, PlayListcontentService } from '@/ServerTypes/Playlist';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Playlist.PlayListcontentDialog')
export class PlayListcontentDialog extends EntityDialog<PlayListcontentRow, any> {
    protected getFormKey() { return PlayListcontentForm.formKey; }
    protected getRowDefinition() { return PlayListcontentRow; }
    protected getService() { return PlayListcontentService.baseUrl; }

    protected form = new PlayListcontentForm(this.idPrefix);
}