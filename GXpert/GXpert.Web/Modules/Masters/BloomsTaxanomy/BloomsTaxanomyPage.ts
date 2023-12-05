import { initFullHeightGridPage } from '@serenity-is/corelib';
import { BloomsTaxanomyGrid } from './BloomsTaxanomyGrid';

export default function pageInit() {
    initFullHeightGridPage(new BloomsTaxanomyGrid($('#GridDiv')).element);
}