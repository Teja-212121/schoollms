import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PlayListcontentGrid } from './PlayListcontentGrid';

export default function pageInit() {
    initFullHeightGridPage(new PlayListcontentGrid($('#GridDiv')).element);
}