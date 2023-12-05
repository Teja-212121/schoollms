import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SchoolGrid } from './SchoolGrid';

export default function pageInit() {
    initFullHeightGridPage(new SchoolGrid($('#GridDiv')).element);
}