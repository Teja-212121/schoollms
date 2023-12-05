import { initFullHeightGridPage } from '@serenity-is/corelib';
import { TalukaGrid } from './TalukaGrid';

export default function pageInit() {
    initFullHeightGridPage(new TalukaGrid($('#GridDiv')).element);
}