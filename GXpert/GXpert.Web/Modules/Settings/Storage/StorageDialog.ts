import { StorageForm, StorageRow, StorageService } from '@/ServerTypes/Settings';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Settings.StorageDialog')
export class StorageDialog extends EntityDialog<StorageRow, any> {
    protected getFormKey() { return StorageForm.formKey; }
    protected getRowDefinition() { return StorageRow; }
    protected getService() { return StorageService.baseUrl; }

    protected form = new StorageForm(this.idPrefix);
}