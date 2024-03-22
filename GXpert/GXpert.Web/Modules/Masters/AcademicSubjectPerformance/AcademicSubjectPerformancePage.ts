import { initFullHeightGridPage } from '@serenity-is/corelib';
import { AcademicSubjectPerformanceGrid } from './AcademicSubjectPerformanceGrid';

export default function pageInit() {
    initFullHeightGridPage(new AcademicSubjectPerformanceGrid($('#GridDiv')).element);
}