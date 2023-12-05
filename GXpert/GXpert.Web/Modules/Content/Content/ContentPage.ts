import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentGrid } from './ContentGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentGrid($('#GridDiv')).element);
}