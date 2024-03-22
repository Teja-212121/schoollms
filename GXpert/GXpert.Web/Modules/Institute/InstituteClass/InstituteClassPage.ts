import { initFullHeightGridPage } from '@serenity-is/corelib';
import { InstituteClassGrid } from './InstituteClassGrid';

export default function pageInit() {
    initFullHeightGridPage(new InstituteClassGrid($('#GridDiv')).element);
}