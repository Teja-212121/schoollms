import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PreAcademicGrid } from './PreAcademicGrid';

export default function pageInit() {
    initFullHeightGridPage(new PreAcademicGrid($('#GridDiv')).element);
}