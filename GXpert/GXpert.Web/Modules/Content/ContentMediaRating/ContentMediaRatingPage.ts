import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentMediaRatingGrid } from './ContentMediaRatingGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentMediaRatingGrid($('#GridDiv')).element);
}