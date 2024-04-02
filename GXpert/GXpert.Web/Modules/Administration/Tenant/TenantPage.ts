import { initFullHeightGridPage } from '@serenity-is/corelib';
import { TenantGrid } from './TenantGrid';

export default function pageInit() {
    initFullHeightGridPage(new TenantGrid($('#GridDiv')).element);
}