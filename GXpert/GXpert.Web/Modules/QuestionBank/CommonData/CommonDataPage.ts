import { initFullHeightGridPage } from '@serenity-is/corelib';
import { CommonDataGrid } from './CommonDataGrid';

export default function pageInit() {
    initFullHeightGridPage(new CommonDataGrid($('#GridDiv')).element);
}