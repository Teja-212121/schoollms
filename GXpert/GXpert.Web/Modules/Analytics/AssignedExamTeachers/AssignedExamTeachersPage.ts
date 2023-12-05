import { initFullHeightGridPage } from '@serenity-is/corelib';
import { AssignedExamTeachersGrid } from './AssignedExamTeachersGrid';

export default function pageInit() {
    initFullHeightGridPage(new AssignedExamTeachersGrid($('#GridDiv')).element);
}