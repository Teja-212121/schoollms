import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentBloomsIndexGrid } from './ContentBloomsIndexGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentBloomsIndexGrid($('#GridDiv')).element);
}