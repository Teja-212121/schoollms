import { initFullHeightGridPage } from '@serenity-is/corelib';
import { TeacherGrid } from './TeacherGrid';

export default function pageInit() {
    initFullHeightGridPage(new TeacherGrid($('#GridDiv')).element);
}