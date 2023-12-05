import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ExamSectionGrid } from './ExamSectionGrid';

export default function pageInit() {
    initFullHeightGridPage(new ExamSectionGrid($('#GridDiv')).element);
}