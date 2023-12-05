import { initFullHeightGridPage } from '@serenity-is/corelib';
import { CouponCodeGrid } from './CouponCodeGrid';

export default function pageInit() {
    initFullHeightGridPage(new CouponCodeGrid($('#GridDiv')).element);
}