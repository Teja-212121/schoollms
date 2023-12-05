import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ActivationLogGrid } from './ActivationLogGrid';

export default function pageInit() {
    initFullHeightGridPage(new ActivationLogGrid($('#GridDiv')).element);
}