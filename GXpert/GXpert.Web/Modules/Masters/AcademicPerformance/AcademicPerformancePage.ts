import { initFullHeightGridPage } from '@serenity-is/corelib';
import { AcademicPerformanceGrid } from './AcademicPerformanceGrid';

export default function pageInit() {
    initFullHeightGridPage(new AcademicPerformanceGrid($('#GridDiv')).element);
}