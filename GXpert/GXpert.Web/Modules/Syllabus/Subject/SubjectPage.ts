import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SubjectGrid } from './SubjectGrid';

export default function pageInit() {
    initFullHeightGridPage(new SubjectGrid($('#GridDiv')).element);
}