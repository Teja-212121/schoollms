import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SchoolTimeTableGrid } from './SchoolTimeTableGrid';

export default function pageInit() {
    initFullHeightGridPage(new SchoolTimeTableGrid($('#GridDiv')).element);
}