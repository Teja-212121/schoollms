import { initFullHeightGridPage } from '@serenity-is/corelib';
import { NotificationGrid } from './NotificationGrid';

export default function pageInit() {
    initFullHeightGridPage(new NotificationGrid($('#GridDiv')).element);
}