import { initFullHeightGridPage } from '@serenity-is/corelib';
import { StudentClassAttendanceGrid } from './StudentClassAttendanceGrid';

export default function pageInit() {
    initFullHeightGridPage(new StudentClassAttendanceGrid($('#GridDiv')).element);
}