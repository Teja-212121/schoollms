import { initFullHeightGridPage } from '@serenity-is/corelib';
import { StorageGrid } from './StorageGrid';

export default function pageInit() {
    initFullHeightGridPage(new StorageGrid($('#GridDiv')).element);
}