import { initFullHeightGridPage } from '@serenity-is/corelib';
import { InstituteStudentGrid } from './InstituteStudentGrid';

export default function pageInit() {
    initFullHeightGridPage(new InstituteStudentGrid($('#GridDiv')).element);
}