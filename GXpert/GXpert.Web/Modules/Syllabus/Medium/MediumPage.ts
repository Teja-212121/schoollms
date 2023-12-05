import { initFullHeightGridPage } from '@serenity-is/corelib';
import { MediumGrid } from './MediumGrid';

export default function pageInit() {
    initFullHeightGridPage(new MediumGrid($('#GridDiv')).element);
}