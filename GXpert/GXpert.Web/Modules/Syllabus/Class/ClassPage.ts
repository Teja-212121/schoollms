import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ClassGrid } from './ClassGrid';

export default function pageInit() {
    initFullHeightGridPage(new ClassGrid($('#GridDiv')).element);
}