import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SemesterGrid } from './SemesterGrid';

export default function pageInit() {
    initFullHeightGridPage(new SemesterGrid($('#GridDiv')).element);
}