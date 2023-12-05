import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentTopicGrid } from './ContentTopicGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentTopicGrid($('#GridDiv')).element);
}