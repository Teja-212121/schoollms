import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PlayListGrid } from './PlayListGrid';

export default function pageInit() {
    initFullHeightGridPage(new PlayListGrid($('#GridDiv')).element);
}