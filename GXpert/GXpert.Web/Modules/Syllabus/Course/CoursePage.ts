import { initFullHeightGridPage } from '@serenity-is/corelib';
import { CourseGrid } from './CourseGrid';

export default function pageInit() {
    initFullHeightGridPage(new CourseGrid($('#GridDiv')).element);
}