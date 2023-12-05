import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ExamAttemptGrid } from './ExamAttemptGrid';

export default function pageInit() {
    initFullHeightGridPage(new ExamAttemptGrid($('#GridDiv')).element);
}