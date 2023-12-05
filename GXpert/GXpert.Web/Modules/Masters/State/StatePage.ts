import { initFullHeightGridPage } from '@serenity-is/corelib';
import { StateGrid } from './StateGrid';

export default function pageInit() {
    initFullHeightGridPage(new StateGrid($('#GridDiv')).element);
}