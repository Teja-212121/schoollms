import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PollGrid } from './PollGrid';

export default function pageInit() {
    initFullHeightGridPage(new PollGrid($('#GridDiv')).element);
}