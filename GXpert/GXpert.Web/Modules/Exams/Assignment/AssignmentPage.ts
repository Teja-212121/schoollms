import { initFullHeightGridPage } from '@serenity-is/corelib';
import { AssignmentGrid } from './AssignmentGrid';

export default function pageInit() {
    initFullHeightGridPage(new AssignmentGrid($('#GridDiv')).element);
}