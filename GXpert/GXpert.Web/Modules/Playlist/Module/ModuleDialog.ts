import { ModuleForm, ModuleRow, ModuleService } from '@/ServerTypes/Playlist';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Playlist.ModuleDialog')
export class ModuleDialog extends EntityDialog<ModuleRow, any> {
    protected getFormKey() { return ModuleForm.formKey; }
    protected getRowDefinition() { return ModuleRow; }
    protected getService() { return ModuleService.baseUrl; }

    protected form = new ModuleForm(this.idPrefix);
}