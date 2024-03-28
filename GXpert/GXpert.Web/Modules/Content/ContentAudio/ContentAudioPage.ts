import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentAudioGrid } from './ContentAudioGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentAudioGrid($('#GridDiv')).element);
}