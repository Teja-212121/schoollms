import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ExamGrid } from './ExamGrid';

export default function pageInit() {
    initFullHeightGridPage(new ExamGrid($('#GridDiv')).element);
}