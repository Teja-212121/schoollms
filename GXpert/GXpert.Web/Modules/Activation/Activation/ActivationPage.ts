import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ActivationGrid } from './ActivationGrid';

export default function pageInit() {
    initFullHeightGridPage(new ActivationGrid($('#GridDiv')).element);
}