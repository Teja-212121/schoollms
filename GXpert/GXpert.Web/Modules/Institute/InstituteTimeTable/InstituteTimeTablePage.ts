import { initFullHeightGridPage } from '@serenity-is/corelib';
import { InstituteTimeTableGrid } from './InstituteTimeTableGrid';

export default function pageInit() {
    initFullHeightGridPage(new InstituteTimeTableGrid($('#GridDiv')).element);
}