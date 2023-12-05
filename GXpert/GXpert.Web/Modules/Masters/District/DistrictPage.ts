import { initFullHeightGridPage } from '@serenity-is/corelib';
import { DistrictGrid } from './DistrictGrid';

export default function pageInit() {
    initFullHeightGridPage(new DistrictGrid($('#GridDiv')).element);
}