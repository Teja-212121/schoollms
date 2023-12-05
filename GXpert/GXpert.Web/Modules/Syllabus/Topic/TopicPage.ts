import { initFullHeightGridPage } from '@serenity-is/corelib';
import { TopicGrid } from './TopicGrid';

export default function pageInit() {
    initFullHeightGridPage(new TopicGrid($('#GridDiv')).element);
}