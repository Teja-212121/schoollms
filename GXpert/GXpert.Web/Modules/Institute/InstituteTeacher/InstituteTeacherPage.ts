import { initFullHeightGridPage } from '@serenity-is/corelib';
import { InstituteTeacherGrid } from './InstituteTeacherGrid';

export default function pageInit() {
    initFullHeightGridPage(new InstituteTeacherGrid($('#GridDiv')).element);
}