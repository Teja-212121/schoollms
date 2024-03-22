import { initFullHeightGridPage } from '@serenity-is/corelib';
import { HodGrid } from './HodGrid';

export default function pageInit() {
    initFullHeightGridPage(new HodGrid($('#GridDiv')).element);
}