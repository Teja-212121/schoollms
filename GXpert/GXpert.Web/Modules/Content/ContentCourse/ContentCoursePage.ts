import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContentCourseGrid } from './ContentCourseGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContentCourseGrid($('#GridDiv')).element);
}