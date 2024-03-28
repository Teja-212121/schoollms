import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentRatingGrid } from './ContentRatingGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentRatingGrid($('#GridDiv')).element);
}