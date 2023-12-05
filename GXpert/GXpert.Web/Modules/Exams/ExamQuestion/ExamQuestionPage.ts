import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ExamQuestionGrid } from './ExamQuestionGrid';

export default function pageInit() {
    initFullHeightGridPage(new ExamQuestionGrid($('#GridDiv')).element);
}