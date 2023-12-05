import { initFullHeightGridPage } from '@serenity-is/corelib';
import { LiveSessionLogGrid } from './LiveSessionLogGrid';

export default function pageInit() {
    initFullHeightGridPage(new LiveSessionLogGrid($('#GridDiv')).element);
}