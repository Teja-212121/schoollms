import { initFullHeightGridPage } from '@serenity-is/corelib';
import { AssignmentAttemptGrid } from './AssignmentAttemptGrid';

export default function pageInit() {
    initFullHeightGridPage(new AssignmentAttemptGrid($('#GridDiv')).element);
}