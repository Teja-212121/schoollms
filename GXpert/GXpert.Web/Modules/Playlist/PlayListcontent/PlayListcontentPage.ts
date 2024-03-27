import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PlayListContentGrid } from './PlayListcontentGrid';

export default function pageInit() {
  initFullHeightGridPage(new PlayListContentGrid($('#GridDiv')).element);
}