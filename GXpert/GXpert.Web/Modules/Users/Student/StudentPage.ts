import { initFullHeightGridPage } from '@serenity-is/corelib';
import { StudentGrid } from './StudentGrid';

export default function pageInit() {
    initFullHeightGridPage(new StudentGrid($('#GridDiv')).element);
}