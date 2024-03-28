import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentLanguageGrid } from './ContentLanguageGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentLanguageGrid($('#GridDiv')).element);
}