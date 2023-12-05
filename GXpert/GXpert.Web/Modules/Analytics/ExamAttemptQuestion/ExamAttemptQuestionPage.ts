import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ExamAttemptQuestionGrid } from './ExamAttemptQuestionGrid';

export default function pageInit() {
    initFullHeightGridPage(new ExamAttemptQuestionGrid($('#GridDiv')).element);
}