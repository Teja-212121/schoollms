import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SmsGrid } from './SmsGrid';

export default function pageInit() {
    initFullHeightGridPage(new SmsGrid($('#GridDiv')).element);
}