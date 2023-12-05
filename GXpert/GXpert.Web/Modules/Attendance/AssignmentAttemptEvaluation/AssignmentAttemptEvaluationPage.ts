import { initFullHeightGridPage } from '@serenity-is/corelib';
import { AssignmentAttemptEvaluationGrid } from './AssignmentAttemptEvaluationGrid';

export default function pageInit() {
    initFullHeightGridPage(new AssignmentAttemptEvaluationGrid($('#GridDiv')).element);
}