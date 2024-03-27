import { initFullHeightGridPage } from '@serenity-is/corelib';
import { InstituteDivisionGrid } from './InstituteDivisionGrid';

export default function pageInit() {
    initFullHeightGridPage(new InstituteDivisionGrid($('#GridDiv')).element);
}