import { initFullHeightGridPage } from '@serenity-is/corelib';
import { LiveSessionGrid } from './LiveSessionGrid';

export default function pageInit() {
    initFullHeightGridPage(new LiveSessionGrid($('#GridDiv')).element);
}