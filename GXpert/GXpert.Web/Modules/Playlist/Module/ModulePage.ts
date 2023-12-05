import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ModuleGrid } from './ModuleGrid';

export default function pageInit() {
    initFullHeightGridPage(new ModuleGrid($('#GridDiv')).element);
}