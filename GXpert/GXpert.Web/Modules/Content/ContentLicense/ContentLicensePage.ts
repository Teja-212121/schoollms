import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentLicenseGrid } from './ContentLicenseGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentLicenseGrid($('#GridDiv')).element);
}