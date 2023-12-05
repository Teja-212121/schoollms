import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SmtpGrid } from './SmtpGrid';

export default function pageInit() {
    initFullHeightGridPage(new SmtpGrid($('#GridDiv')).element);
}