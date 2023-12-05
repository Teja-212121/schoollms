import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SchoolClassGrid } from './SchoolClassGrid';

export default function pageInit() {
    initFullHeightGridPage(new SchoolClassGrid($('#GridDiv')).element);
}