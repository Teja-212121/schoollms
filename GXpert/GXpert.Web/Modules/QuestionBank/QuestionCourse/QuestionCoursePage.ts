import { initFullHeightGridPage } from '@serenity-is/corelib';
import { QuestionCourseGrid } from './QuestionCourseGrid';

export default function pageInit() {
    initFullHeightGridPage(new QuestionCourseGrid($('#GridDiv')).element);
}