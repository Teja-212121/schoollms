import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SerialKeyGrid } from './SerialKeyGrid';

export default function pageInit() {
    initFullHeightGridPage(new SerialKeyGrid($('#GridDiv')).element);
}