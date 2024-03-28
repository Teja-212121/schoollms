import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentCategoryGrid } from './ContentCategoryGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentCategoryGrid($('#GridDiv')).element);
}