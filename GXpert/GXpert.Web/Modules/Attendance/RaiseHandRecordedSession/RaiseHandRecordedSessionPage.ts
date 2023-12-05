import { initFullHeightGridPage } from '@serenity-is/corelib';
import { RaiseHandRecordedSessionGrid } from './RaiseHandRecordedSessionGrid';

export default function pageInit() {
    initFullHeightGridPage(new RaiseHandRecordedSessionGrid($('#GridDiv')).element);
}