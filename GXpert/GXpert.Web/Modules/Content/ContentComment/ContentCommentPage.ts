import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentCommentGrid } from './ContentCommentGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentCommentGrid($('#GridDiv')).element);
}