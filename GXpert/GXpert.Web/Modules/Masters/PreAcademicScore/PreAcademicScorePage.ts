import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PreAcademicScoreGrid } from './PreAcademicScoreGrid';

export default function pageInit() {
    initFullHeightGridPage(new PreAcademicScoreGrid($('#GridDiv')).element);
}