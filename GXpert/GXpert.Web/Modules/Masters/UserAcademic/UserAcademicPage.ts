import { initFullHeightGridPage } from '@serenity-is/corelib';
import { UserAcademicGrid } from './UserAcademicGrid';

export default function pageInit() {
    initFullHeightGridPage(new UserAcademicGrid($('#GridDiv')).element);
}