import { initFullHeightGridPage } from '@serenity-is/corelib';
import { DepartmentGrid } from './DepartmentGrid';

export default function pageInit() {
    initFullHeightGridPage(new DepartmentGrid($('#GridDiv')).element);
}