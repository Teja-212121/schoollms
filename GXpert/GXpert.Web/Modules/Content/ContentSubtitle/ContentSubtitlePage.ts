import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentSubtitleGrid } from './ContentSubtitleGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentSubtitleGrid($('#GridDiv')).element);
}