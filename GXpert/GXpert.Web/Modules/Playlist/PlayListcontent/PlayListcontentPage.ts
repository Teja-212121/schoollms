import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PlayListContentGrid } from './PlayListContentGrid';

export default function pageInit() {
    initFullHeightGridPage(new PlayListContentGrid($('#GridDiv')).element);
}