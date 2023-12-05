import { initFullHeightGridPage } from '@serenity-is/corelib';
import { AssignmentEvaluationGrid } from './AssignmentEvaluationGrid';

export default function pageInit() {
    initFullHeightGridPage(new AssignmentEvaluationGrid($('#GridDiv')).element);
}