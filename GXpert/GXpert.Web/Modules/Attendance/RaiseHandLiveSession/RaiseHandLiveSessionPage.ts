import { initFullHeightGridPage } from '@serenity-is/corelib';
import { RaiseHandLiveSessionGrid } from './RaiseHandLiveSessionGrid';

export default function pageInit() {
    initFullHeightGridPage(new RaiseHandLiveSessionGrid($('#GridDiv')).element);
}