import { PlayListContentForm, PlayListContentRow, PlayListContentService } from '@/ServerTypes/Playlist';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Playlist.PlayListContentDialog')
export class PlayListContentDialog extends EntityDialog<PlayListContentRow, any> {
    protected getFormKey() { return PlayListContentForm.formKey; }
    protected getRowDefinition() { return PlayListContentRow; }
    protected getService() { return PlayListContentService.baseUrl; }

    protected form = new PlayListContentForm(this.idPrefix);
}