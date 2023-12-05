import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SchoolStudentGrid } from './SchoolStudentGrid';

export default function pageInit() {
    initFullHeightGridPage(new SchoolStudentGrid($('#GridDiv')).element);
}