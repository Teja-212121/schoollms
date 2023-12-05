import { initFullHeightGridPage } from '@serenity-is/corelib';
import { AnalyticsLogGrid } from './AnalyticsLogGrid';

export default function pageInit() {
    initFullHeightGridPage(new AnalyticsLogGrid($('#GridDiv')).element);
}