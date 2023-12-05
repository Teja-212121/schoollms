import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SchoolTeacherGrid } from './SchoolTeacherGrid';

export default function pageInit() {
    initFullHeightGridPage(new SchoolTeacherGrid($('#GridDiv')).element);
}