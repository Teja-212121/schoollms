import { initFullHeightGridPage } from '@serenity-is/corelib';
import { AcademicYearGrid } from './AcademicYearGrid';

export default function pageInit() {
    initFullHeightGridPage(new AcademicYearGrid($('#GridDiv')).element);
}