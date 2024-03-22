import { initFullHeightGridPage } from '@serenity-is/corelib';
import { BranchGrid } from './BranchGrid';

export default function pageInit() {
    initFullHeightGridPage(new BranchGrid($('#GridDiv')).element);
}