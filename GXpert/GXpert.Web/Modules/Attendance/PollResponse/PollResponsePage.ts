import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PollResponseGrid } from './PollResponseGrid';

export default function pageInit() {
    initFullHeightGridPage(new PollResponseGrid($('#GridDiv')).element);
}